use SegurityCulturaTourDb;
CREATE TABLE LoginUser (
	id INT PRIMARY KEY IDENTITY (1,1),
	EmailLogin varchar (100) NOT NULL,
	PasswordLogin varchar (100) NOT NULL,
);