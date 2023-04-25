package com.phoenix.Phoenix.Password.Manager.repositorymongodb;

import com.phoenix.Phoenix.Password.Manager.repository.PasswordRepository;
import com.phoenix.Phoenix.Password.Manager.service.password.Password;
import org.springframework.data.repository.Repository;

@org.springframework.stereotype.Repository
public interface PasswordRepositoryMongoDB extends PasswordRepository, Repository<Password,String> {
}
