package com.phoenix.Phoenix.Password.Manager.service.register;

import com.phoenix.Phoenix.Password.Manager.repository.UserRepository;
import com.phoenix.Phoenix.Password.Manager.service.User;
import org.springframework.stereotype.Service;

import java.util.Optional;
import java.util.UUID;

@Service
class DefaultRegistrationService implements RegistrationService{

    private UserRepository userRepository;


    public DefaultRegistrationService(UserRepository userRepository){
        this.userRepository = userRepository;
    }

    @Override
    public RegistrationResult requestRegistration(RegistrationServiceRequest request) {
        Optional<User> userOptional = userRepository.getByEmail(request.getEmail());
        if(userOptional.isPresent()){
            return RegistrationResult.CONFLICT;
        }
        final User newUser = new User()
                .setId(UUID.randomUUID().toString())
                .setEmail(request.getEmail())
                .setName(request.getName())
                .setPasswordHash(request.getPassword() + "hashed")
                .setEnabled(true)
                .setVerified(true);

        userRepository.save(newUser);
        return RegistrationResult.SUCCESS;
    }
}