-- Schemas

CREATE TABLE session_timing(
   session_id SERIAL,
   expiration TIME NOT NULL,
   PRIMARY KEY(session_id)
);

CREATE TABLE compte_tentative(
   compte_tentative_id SERIAL,
   compte INTEGER NOT NULL,
   PRIMARY KEY(compte_tentative_id)
);

CREATE TABLE users(
   user_id SERIAL,
   user_name VARCHAR(70)  NOT NULL,
   user_email VARCHAR(70)  NOT NULL,
   user_password VARCHAR(256)  NOT NULL,
   user_token VARCHAR(255) ,
   PRIMARY KEY(user_id)
);

CREATE TABLE confirmationEmail(
   confirmation_email_id SERIAL,
   created_at TIMESTAMP NOT NULL,
   expires_at TIMESTAMP,
   PIN VARCHAR(50)  NOT NULL,
   user_id INTEGER NOT NULL,
   PRIMARY KEY(confirmation_email_id),
   FOREIGN KEY(user_id) REFERENCES Users(user_id)
);

CREATE TABLE login(
   login_id SERIAL,
   connexion_date TIMESTAMP NOT NULL,
   user_id INTEGER NOT NULL,
   PRIMARY KEY(login_id),
   FOREIGN KEY(user_id) REFERENCES Users(user_id)
);

CREATE TABLE tentatives(
   tentative_id SERIAL,
   status BOOLEAN NOT NULL,
   login_id INTEGER NOT NULL,
   PRIMARY KEY(tentative_id),
   FOREIGN KEY(login_id) REFERENCES login(login_id)
);
