\connect customersdb
CREATE TABLE IF NOT EXISTS customer
(
 id serial PRIMARY KEY,
 full_name VARCHAR(100) NOT NULL,
 date_of_birth DATE NOT NULL,
 gender VARCHAR(50), NOT NULL,
 cuil VARCHAR(20) UNIQUE, NOT NULL,
 phone VARCHAR(50),NOT NULL,
 deleted BOOLEAN  NOT NULL DEFAULT 'false'
);
ALTER TABLE "customer" OWNER TO postgres;
Insert into customer(full_name,date_of_birth, gender, cuil, phone, deleted) values( "Juan Gomez","1996/12/31","M","28-95722569-2","4444444");
Insert into customer(full_name,date_of_birth, gender, cuil, phone, deleted) values( "Camilo Gomez","1995/10/20","M","23-91148569-4","4458964");
Insert into customer(full_name,date_of_birth, gender, cuil, phone, deleted) values( "Camila Gimenez","1998/11/05","F","22-95788569-3","4472564");
Insert into customerfull_name,date_of_birth, gender, cuil, phone, deleted) values( "Paula Perez","1992/08/10","F","21-95748578-5","4402454");
Insert into customer(full_name,date_of_birth, gender, cuil, phone, deleted) values( "Carlos Cuadros","1991/07/15","M","24-95258569-7","4478954");
Insert into customer(full_name,date_of_birth, gender, cuil, phone, deleted) values( "Marlon Saenz","1995/07/20","M","23-95748789-2","4782444",true);
Insert into customer(full_name,date_of_birth, gender, cuil, phone, deleted) values( "Perla Saenz","1991/06/08","F","22-95752389-3","4636344");
Insert into customer(full_name,date_of_birth, gender, cuil, phone, deleted) values( "Pablo Restrepo","1992/02/02","M","25-95745189-1","4888844",true);

