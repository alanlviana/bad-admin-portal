CREATE TABLE IF NOT EXISTS product (
	id INTEGER PRIMARY KEY,
    description TEXT NOT NULL,
    price REAL NOT NULL
);

CREATE TABLE IF NOT EXISTS user (
	username TEXT NOT NULL PRIMARY KEY,
	password TEXT NOT NULL
);

INSERT INTO product (description, price) VALUES ('Feijoada', 25.99);
INSERT INTO product (description, price) VALUES ('Pão de Queijo', 12.99);
INSERT INTO product (description, price) VALUES ('Brigadeiro', 8.99);
INSERT INTO product (description, price) VALUES ('Coxinha', 15.99);
INSERT INTO product (description, price) VALUES ('Açaí Bowl', 18.99);
INSERT INTO product (description, price) VALUES ('Moqueca', 30.99);
INSERT INTO product (description, price) VALUES ('Pastel', 10.99);
INSERT INTO product (description, price) VALUES ('Feijão Tropeiro', 22.99);
INSERT INTO product (description, price) VALUES ('Tapioca', 14.99);
INSERT INTO product (description, price) VALUES ('Vatapá', 27.99);
INSERT INTO product (description, price) VALUES ('Quindim', 9.99);
INSERT INTO product (description, price) VALUES ('Cachorro-Quente', 12.99);
INSERT INTO product (description, price) VALUES ('Acarajé', 20.99);
INSERT INTO product (description, price) VALUES ('Bolo de Rolo', 16.99);
INSERT INTO product (description, price) VALUES ('Canjica', 11.99);


INSERT INTO user (username, password) VALUES ('admin', 'jerrys');
INSERT INTO user (username, password) VALUES ('JohnDoe', 'P@ssw0rd1');
INSERT INTO user (username, password) VALUES ('JaneSmith', 'Secret123');
INSERT INTO user (username, password) VALUES ('MichaelJohnson', 'Pa$$w0rd!');
INSERT INTO user (username, password) VALUES ('EmilyDavis', 'SecurePass1');
INSERT INTO user (username, password) VALUES ('ChristopherBrown', 'P@ss1234');
INSERT INTO user (username, password) VALUES ('AmandaMiller', 'StrongPwd!2');
INSERT INTO user (username, password) VALUES ('DanielWilliams', 'Pa$$w0rd789');
INSERT INTO user (username, password) VALUES ('OliviaJones', 'Pass123!');
INSERT INTO user (username, password) VALUES ('MatthewTaylor', 'SecurePwd456');
INSERT INTO user (username, password) VALUES ('EmmaJohnson', 'P@ssword789');
INSERT INTO user (username, password) VALUES ('WilliamSmith', 'SecretPass12');
INSERT INTO user (username, password) VALUES ('SophiaWhite', 'RandomPwd!3');
INSERT INTO user (username, password) VALUES ('JamesMartin', 'P@ssw0rd456');
INSERT INTO user (username, password) VALUES ('IsabellaClark', 'StrongPass!4');
INSERT INTO user (username, password) VALUES ('EthanWilson', 'Random12345');