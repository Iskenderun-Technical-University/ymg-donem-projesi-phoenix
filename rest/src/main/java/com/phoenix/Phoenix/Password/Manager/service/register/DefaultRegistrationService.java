package com.phoenix.Phoenix.Password.Manager.service.register;

import com.phoenix.Phoenix.Password.Manager.repository.UserRepository;
import com.phoenix.Phoenix.Password.Manager.service.User;
import com.phoenix.Phoenix.Password.Manager.service.password.PasswordEncoder;
import com.phoenix.Phoenix.Password.Manager.support.result.CreationResult;
import com.phoenix.Phoenix.Password.Manager.support.result.OperationFailureReason;
import org.springframework.stereotype.Service;

import java.util.Map;
import java.util.Optional;
import java.util.UUID;

@Service
class DefaultRegistrationService implements RegistrationService{

    private final UserRepository userRepository;


    public DefaultRegistrationService(UserRepository userRepository){
        this.userRepository = userRepository;
    }

    @Override
    public CreationResult<?> requestRegistration(RegistrationServiceRequest request) {
        Optional<User> userOptional = userRepository.getByEmail(request.getEmail());
        if(userOptional.isPresent()){
            return CreationResult.<User>failed(OperationFailureReason.CONFLICT,"Email has already registered.");
        }
        final User newUser = new User()
                .setId(UUID.randomUUID().toString())
                .setEmail(request.getEmail())
                .setName(request.getName())
                .setPasswordHash(PasswordEncoder.encode(request.getPassword()))
                .setEnabled(true)
                .setVerified(true);

        userRepository.save(newUser);
        return CreationResult.success(Map.of("userId",newUser.getId()));
    }
}
