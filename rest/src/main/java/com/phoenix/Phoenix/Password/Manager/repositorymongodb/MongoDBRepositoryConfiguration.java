package com.phoenix.Phoenix.Password.Manager.repositorymongodb;

import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;
import org.springframework.data.mongodb.config.EnableMongoAuditing;
import org.springframework.data.mongodb.repository.config.EnableMongoRepositories;

@Configuration
@ComponentScan
@EnableMongoRepositories
@EnableMongoAuditing
public class MongoDBRepositoryConfiguration {
}
