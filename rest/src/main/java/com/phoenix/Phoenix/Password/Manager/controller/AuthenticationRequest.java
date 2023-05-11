package com.phoenix.Phoenix.Password.Manager.controller;


public class AuthenticationRequest {
        private String email;
        private String password;

        public AuthenticationRequest(){}

        private AuthenticationRequest(AuthenticationRequestBuilder builder){
                this.email = builder.email;
                this.password = builder.password;
        }

        public String getEmail() {
                return email;
        }

        public AuthenticationRequest setEmail(String email) {
                this.email = email;
                return this;
        }

        public String getPassword() {
                return password;
        }

        public AuthenticationRequest setPassword(String password) {
                this.password = password;
                return this;
        }

        public static class AuthenticationRequestBuilder{
                private String email;
                private String password;

                public AuthenticationRequestBuilder(String email, String password) {
                        this.email = email;
                        this.password = password;
                }

                public AuthenticationRequestBuilder setEmail(String email) {
                        this.email = email;
                        return this;
                }

                public AuthenticationRequestBuilder setPassword(String password) {
                        this.password = password;
                        return this;
                }

                public AuthenticationRequest build(){
                        return new AuthenticationRequest(this);
                }
        }
}
