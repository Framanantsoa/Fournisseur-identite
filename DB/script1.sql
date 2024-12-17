CREATE USER web with password 'web';
CREATE DATABASE identity_provider;
ALTER DATABASE identity_provider OWNER TO web;

\c identity_provider web;
