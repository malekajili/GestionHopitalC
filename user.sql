
CREATE TABLE roles (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL UNIQUE
);

INSERT INTO roles (name) VALUES ('ADMIN'), ('DOCTOR'), ('RECEPTIONIST'), ('PATIENT');

CREATE TABLE users (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(191),
    password TEXT,
    email VARCHAR(100)NOT NULL UNIQUE,
    gender VARCHAR(10),
    phone VARCHAR(20),
    age INT,
    role_id INT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (role_id) REFERENCES roles(id)
);

INSERT INTO users (name, password, email, gender, phone, age, role_id) 
VALUES ('admin', SHA2('password', 256),'admin@gmail.com', 'Masculin','589647123',54, 1);

CREATE TABLE patients (
    id INT PRIMARY KEY AUTO_INCREMENT,
    user_id INT NOT NULL,
    address VARCHAR(255),
    FOREIGN KEY (user_id) REFERENCES users(id)
);
CREATE TABLE doctors (
    id INT PRIMARY KEY AUTO_INCREMENT,
    user_id INT NOT NULL,
    speciality VARCHAR(255),
    FOREIGN KEY (user_id) REFERENCES users(id)
);