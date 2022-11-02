\connect customersdb
CREATE TABLE IF NOT EXISTS customers
(
 id serial PRIMARY KEY,
 full_name VARCHAR (100) NOT NULL,
 date_of_birth DATE NOT NULL,
 gender VARCHAR (50), NOT NULL,
 cuil VARCHAR(20) UNIQUE, NOT NULL,
 phone VARCHAR(50),NOT NULL,
 deleted BOOLEAN  NOT NULL DEFAULT 'false'
);
ALTER TABLE "customers" OWNER TO postgres;
Insert into customers(full_name,date_of_birth, gender, cuil, phone, deleted) values( "Juan Gomez","1996/12/31","28-95722569-2","4444444",false);
Insert into customers(full_name,date_of_birth, gender, cuil, phone, deleted) values( "Camilo Gomez","1995/10/20","23-91148569-4","4458964",false);
Insert into customers(full_name,date_of_birth, gender, cuil, phone, deleted) values( "Camila Gimenez","1998/11/05","22-95788569-3","4472564",false);
Insert into customers(full_name,date_of_birth, gender, cuil, phone, deleted) values( "Paula Perez","1992/08/10","21-95748578-5","4402454",false);
Insert into customers(full_name,date_of_birth, gender, cuil, phone, deleted) values( "Carlos Cuadros","1991/07/15","24-95258569-7","4478954",false);
Insert into customers(full_name,date_of_birth, gender, cuil, phone, deleted) values( "Marlon Saenz","1995/07/20","23-95748789-2","4782444",true);
Insert into customers(full_name,date_of_birth, gender, cuil, phone, deleted) values( "Perla Saenz","1991/06/08","22-95752389-3","4636344",false);
Insert into customers(full_name,date_of_birth, gender, cuil, phone, deleted) values( "Pablo Restrepo","1992/02/02","25-95745189-1","4888844",true);

