package com.phoenix.Phoenix.Password.Manager.service.register;

import com.phoenix.Phoenix.Password.Manager.repository.UserRepository;
import com.phoenix.Phoenix.Password.Manager.service.User;
import com.phoenix.Phoenix.Password.Manager.support.result.CreationResult;
import com.phoenix.Phoenix.Password.Manager.support.result.OperationFailureReason;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Nested;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.extension.ExtendWith;
import org.mockito.ArgumentCaptor;
import org.mockito.Captor;
import org.mockito.Mock;
import org.mockito.Mockito;
import org.mockito.junit.jupiter.MockitoExtension;

import java.util.Optional;

import static org.assertj.core.api.AssertionsForClassTypes.assertThat;
import static org.junit.jupiter.api.Assertions.*;

@ExtendWith(MockitoExtension.class)
class DefaultRegistrationServiceTest {

    @Mock
    private UserRepository userRepository;

    private DefaultRegistrationService service;


    @BeforeEach
    void setUp(){
        this.service = new DefaultRegistrationService(userRepository);
    }

    @Nested
    class RegistrationTests {

        RegistrationServiceRequest request;

        @Captor
        ArgumentCaptor<User> userArgumentCaptor;

        @BeforeEach
        void setUp(){
            request = new RegistrationServiceRequest()
                    .setEmail("user@email.com")
                    .setName("username")
                    .setPassword("password");
        }

        @Test
        void emailIsAlreadyInUse() {
            final User user = new User()
                    .setId("id")
                    .setEmail("user@email.com")
                    .setName("name")
                    .setPasswordHash("passwordHash")
                    .setVerified(true)
                    .setEnabled(true);

            Mockito.doReturn(Optional.of(user))
                    .when(userRepository)
                    .getByEmail(request.getEmail());

            final CreationResult<?> result = service.requestRegistration(request);
            assertFalse(result.isSuccess());
            assertEquals(OperationFailureReason.CONFLICT,result.getReason());
        }

        @Test
        void success(){
            Mockito.doReturn(Optional.empty())
                    .when(userRepository)
                    .getByEmail(request.getEmail());

            CreationResult<?> result = service.requestRegistration(request);
            assertTrue(result.isSuccess());

            Mockito.verify(userRepository)
                    .save(userArgumentCaptor.capture());

            final User user = userArgumentCaptor.getValue();
            assertEquals(request.getName(),user.getName());
            assertEquals(request.getEmail(),user.getEmail());
            assertNotEquals(request.getPassword(),user.getPasswordHash());
            assertThat(user.getId()).isNotNull().isNotBlank();
            assertThat(user.getEnabled()).isTrue();
        }

    }

}