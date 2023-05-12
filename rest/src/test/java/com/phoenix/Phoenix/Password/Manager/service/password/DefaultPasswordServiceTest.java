package com.phoenix.Phoenix.Password.Manager.service.password;

import com.phoenix.Phoenix.Password.Manager.repository.PasswordRepository;
import com.phoenix.Phoenix.Password.Manager.support.result.CreationResult;
import com.phoenix.Phoenix.Password.Manager.support.result.OperationFailureReason;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Nested;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.extension.ExtendWith;
import org.mockito.Mock;
import org.mockito.Mockito;
import org.mockito.junit.jupiter.MockitoExtension;

import java.util.Optional;

import static org.junit.jupiter.api.Assertions.*;

@ExtendWith(MockitoExtension.class)
class DefaultPasswordServiceTest {

    @Mock
    private PasswordRepository passwordRepository;
    private DefaultPasswordService defaultPasswordService;

    @BeforeEach
    void setUp() {
        defaultPasswordService = new DefaultPasswordService(passwordRepository);
    }

    @Nested
    class SavePassword {
        /*
          -title boş
          -title daha önce kaydedilmiş olabilir
          -başarılı

         */
        @Test
        void titleIsEmpty() {
            Password password = new Password()
                    .setId("ID")
                    .setPassword("melis1234")
                    .setUsername("melis");


            final CreationResult<?> result = defaultPasswordService.savePassword(password);

            assertFalse(result.isSuccess());
            assertEquals(OperationFailureReason.PRECONDITION_FAILED, result.getReason());

        }

        @Test
        void titleAlreadyUsed() {

            Password password = new Password()
                    .setId("ID")
                    .setPassword("melis1234")
                    .setUsername("melis")
                    .setTitle("title");


            Mockito.doReturn(Optional.of(password)).when(passwordRepository).getByTitle(password.getTitle());
            final CreationResult<?> result = defaultPasswordService.savePassword(password);
            assertFalse(result.isSuccess());
            assertEquals(OperationFailureReason.CONFLICT, result.getReason());
        }


        @Test
        void success()
        {
            Password password = new Password()
                    .setPassword("melis1234")
                    .setUsername("melis")
                    .setTitle("title");


            Mockito.doReturn(Optional.empty()).when(passwordRepository).getByTitle(password.getTitle());
            final CreationResult<?> result = defaultPasswordService.savePassword(password);

              assertTrue(result.isSuccess());
              Mockito.verify(passwordRepository).save(password);


        }



    }

    @Nested
    class UpdatePassword
    {
        /*
        - invalid ıd
        - already used title
        - success
         */
        @Test
        void invalidId()
        {
            Mockito.doReturn(Optional.empty())
                    .when(passwordRepository)
                    .getById("id");

            final CreationResult<?> result = defaultPasswordService.updatePassword("id",new Password());

            assertFalse(result.isSuccess());
            assertEquals(OperationFailureReason.PRECONDITION_FAILED, result.getReason());
        }

        @Test
        void titleUsedAlready()
        {
            Password password = new Password()
                    .setId("ID")
                    .setPassword("melis1234")
                    .setUsername("melis")
                    .setTitle("title");

            Mockito.doReturn(Optional.of(password)).when(passwordRepository).getByTitle(password.getTitle());
            final CreationResult<?> result = defaultPasswordService.updatePassword("id",password);
            assertFalse(result.isSuccess());
            assertEquals(OperationFailureReason.CONFLICT, result.getReason());

        }

    }

}