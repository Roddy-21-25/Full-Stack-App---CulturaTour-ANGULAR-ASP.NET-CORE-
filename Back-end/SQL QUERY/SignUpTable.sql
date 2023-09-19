use SegurityCulturaTourDb;
CREATE TABLE SignUpUser (
	id INT PRIMARY KEY IDENTITY (1,1),
	Nombre varchar (50) NOT NULL,
	Apellido varchar (50) NOT NULL,
	EmailSignUp varchar (100) NOT NULL,
	PasswordSignUp varchar (100) NOT NULL,
);