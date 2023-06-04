package com.phoenix.Phoenix.Password.Manager.repositorymongodb;

import com.phoenix.Phoenix.Password.Manager.repository.UserRepository;
import com.phoenix.Phoenix.Password.Manager.service.user.User;
import org.springframework.data.repository.Repository;


@org.springframework.stereotype.Repository
public interface UserRepositoryMongoDB extends UserRepository, Repository<User, String> {
}
