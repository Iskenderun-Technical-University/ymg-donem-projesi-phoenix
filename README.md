[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/QA5O9x4M)
# Phoenix
### Password Manager Application
________________
* ##### Phoenix is allows user to CRUD operations to passwords and generate safe passwords with options (length,uppercase chars, lowercase chars, special chars,numbers) and stores passwords in encrypted form in safe repositories.
![]()
CRUD : Create, Read, Update, Delete
![]()
__________________

* ### Installation
_____________
#### Backend
* ##### You need to install Maven first.
    * ##### To Install Maven
    [You can follow these steps.](https://www.baeldung.com/install-maven-on-windows-linux-mac)

* ##### This apps running on JDK-17 
    * ##### To Install JDK-17
    You can install [Eclipse Temurin-17](https://adoptium.net/temurin/releases/)

* ##### Open IDE and Run Maven Build

* ##### To Install MongoDB Database
    1. Download Docker Desktop or Docker Engine from official site(https://docs.docker.com/engine/install/)
    2. After installation open terminal and type following commands:
        ```
        docker pull mongo
        docker run --name mongodb -dp 27017:27017 mongo
        ```
    3. You can start using application.

* ##### To Install MailDev Server
    [You can follow these steps](https://devnote.tech/2021/08/maildev-docker-mail-server-on-your-local-environment/)
_______________
#### Desktop App
* ##### You should have installed [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
_______

### Endpoints

```https://localhost:8080/api/auth/register```
```https://localhost:8080/api/auth/login```
```https://localhost:8080/api/auth/verify```
```https://localhost:8080/api/auth/reset-password```
```https://localhost:8080/api/me/password```


__________


* #####  **Password Manager Application Features**
    - ***Save password***
    - ***Update password***
    - ***Delete password***
    - ***View password***
    - ***Generate Password***
 ![]()
_________________

* ### Used Technologies
    - Java 17 and Java Spring Boot for back-end services
    - C# for desktop application
    - Maven for managing application
    - Git for VCS
![]()
_______________________


* ### Developers
    - Muhammet Emin Özkan
    - Melis Ölmez
![]()
_______________________

## UML Diagram
[![UML](https://github.com/Iskenderun-Technical-University/ymg-donem-projesi-phoenix/blob/main/passwordManagerAppUML.png)](https://github.com/Iskenderun-Technical-University/ymg-donem-projesi-phoenix/blob/main/passwordManagerAppUML.png?raw=true)