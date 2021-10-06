CREATE DATABASE Purchase
CREATE TABLE SALESMEN(SALESMAN_ID NUMERIC(5) PRIMARY KEY, NAME VARCHAR(30), CITY VARCHAR(15),COMMISSION DECIMAL(5,2))
CREATE TABLE CUSTOMER(CUSTOMER_ID NUMERIC(5) PRIMARY KEY, CUST_NAME VARCHAR(30), CITY VARCHAR(15),GRADE NUMERIC(3),SALESMAN_ID NUMERIC(5) FOREIGN KEY (SALESMAN_ID) REFERENCES SALESMEN(SALESMAN_ID))
CREATE TABLE ORDERS(ORD_NO NUMERIC(5) PRIMARY KEY, PURCH_AMT DECIMAL(8,2), ORD_DATE DATE, CUSTOMER_ID NUMERIC(5) FOREIGN KEY (CUSTOMER_ID) REFERENCES CUSTOMER(CUSTOMER_ID), SALESMAN_ID NUMERIC(5) FOREIGN KEY (SALESMAN_ID) REFERENCES SALESMEN(SALESMAN_ID))
insert into SALESMEN values(5001,'James Hoog','New York',0.15);
insert into SALESMEN values(5002,'Nail Knite','Paris',0.13);
insert into SALESMEN values(5005,'Pit Alex','London',0.11);
insert into SALESMEN values(5006,'Mc Lyon','Paris',0.14);
insert into SALESMEN values(5007,'Paul Adam','Rome',0.13);
insert into SALESMEN values(5003,'Lauson Hen','San Jose',0.12);

insert into CUSTOMER values(3002,'Nick Rimando','New York',100,5001);
insert into customer values(3007,'Brad Davis','New York',200,5001);
insert into customer values(3005,'Graham Zusi','California',200,5002);
insert into customer values(3008,'Julian Green','London',300,5002);
insert into customer values(3004,'Fabian Johnson','Paris',300,5006);
insert into customer values(3009,'Geoff Cameron','Berlin',100,5003);
insert into customer values(3003,'Jozy Altidor','Moscow',200,5007);
insert into customer values(3001,'Brad Guzon','London',NULL,5005);

SELECT * FROM CUSTOMER

--insert into Orders values (70001, 150.5, '2012-10-05', 3005, 5002);
--insert into Orders values (70009, 270.65, '2012-09-10', 3001, 5005);
--insert into Orders values (70002, 65.26, '2012-10-05', 3002, 5001);
--insert into Orders values (70004, 110.5, '2012-08-17', 3009, 5003);
--insert into Orders values (70007, 948.5, '2012-09-10', 3005, 5002);
--insert into Orders values (70005, 2400.6, '2012-07-27', 3007, 5001);
--insert into Orders values (70008, 5760, '2012-09-10', 3002, 5001);
--insert into Orders values (70010, 1983.43, '2012-10-10', 3004, 5006);
--insert into Orders values (70003, 2480.4, '2012-10-10', 3009, 5003);
--insert into Orders values (70012, 250.45, '2012-06-27', 3008, 5002);
insert into Orders values (70011, 75.29, '2012-08-17', 3003, 5007);
insert into Orders values (70013, 3045.6, '2012-04-25', 3002, 5001);
SELECT * FROM ORDERS;

--1.
SELECT * FROM SALESMEN
--2.
SELECT NAME, COMMISSION FROM SALESMEN
--3.
SELECT ORD_DATE, SALESMAN_ID, ORD_NO, PURCH_AMT FROM ORDERS
--4.
SELECT DISTINCT SALESMAN_ID FROM ORDERS
--5.
SELECT NAME, CITY FROM SALESMEN WHERE CITY='PARIS'
--6.
SELECT customer_id, cust_name, city, grade, salesman_id FROM CUSTOMER WHERE GRADE=200
--7.
SELECT ord_no, ord_date, purch_amt FROM ORDERS WHERE SALESMAN_ID=5001
--8.
SELECT customer_id, cust_name, city, grade, salesman_id FROM CUSTOMER WHERE GRADE > 100
--9.
SELECT * FROM CUSTOMER WHERE CITY='NEW YORK' AND GRADE>100
--10.
SELECT * FROM CUSTOMER WHERE CITY='NEW YORK' OR GRADE >100
--11.
SELECT * FROM CUSTOMER WHERE CITY='NEW YORK' OR GRADE !>100
--12.
SELECT * FROM CUSTOMER WHERE CITY!='NEW YORK' AND GRADE !>100
--13.
SELECT * FROM ORDERS WHERE NOT (ORD_DATE='2012-09-10' AND SALESMAN_ID>5005 OR PURCH_AMT>1000)
--14.
SELECT * FROM SALESMEN WHERE COMMISSION BETWEEN 0.10 AND 0.12
--15.
SELECT SUM(PURCH_AMT) FROM ORDERS 
--16.
SELECT AVG(PURCH_AMT) FROM ORDERS 
--17.
SELECT COUNT(DISTINCT SALESMAN_ID) FROM SALESMEN
--18.
SELECT COUNT(CUSTOMER_ID) FROM CUSTOMER
--19.
SELECT COUNT (ALL grade) FROM customer;
--20.
SELECT MAX (purch_amt) FROM orders;
--21.
SELECT MIN (purch_amt) FROM orders;
--22.
SELECT customer_id,ord_date,MAX(purch_amt) FROM orders GROUP BY customer_id,ord_date HAVING MAX(purch_amt)>2000.00;
--23.
SELECT customer_id,ord_date,MAX(purch_amt) FROM orders GROUP BY customer_id,ord_date HAVING MAX(purch_amt) BETWEEN 2000 AND 6000;
--24.
SELECT customer_id,ord_date,MAX(purch_amt) FROM orders GROUP BY customer_id,ord_date HAVING MAX(purch_amt) IN(2000 ,3000,5760, 6000);
--25.
SELECT customer_id,MAX(purch_amt) FROM orders WHERE customer_id BETWEEN 3002 and 3007 GROUP BY customer_id HAVING MAX(purch_amt)>1000;

SELECT * FROM SALESMEN
SELECT * FROM CUSTOMER
SELECT * FROM ORDERS
--26.
SELECT * FROM ORDERS WHERE SALESMAN_ID =(SELECT SALESMAN_ID FROM SALESMEN WHERE NAME='Paul Adam')
--27.
SELECT * FROM ORDERS WHERE SALESMAN_ID =(SELECT SALESMAN_ID FROM SALESMEN WHERE CITY='LONDON')
--28.
SELECT * FROM ORDERS WHERE SALESMAN_ID=(SELECT SALESMAN_ID  FROM ORDERS WHERE CUSTOMER_ID=3007)
--29.
SELECT * FROM ORDERS WHERE PURCH_AMT >(SELECT AVG(PURCH_AMT) FROM ORDERS WHERE ORD_DATE='2012-10-10')
--30.
SELECT * FROM ORDERS WHERE SALESMAN_ID IN ( SELECT SALESMAN_ID FROM SALESMEN WHERE CITY = 'NEW YORK')
--31.
SELECT COMMISSION FROM SALESMEN WHERE CITY='PARIS'
--32.

--33.
SELECT GRADE, COUNT(*) FROM CUSTOMER GROUP BY GRADE  HAVING GRADE> (SELECT AVG(GRADE) FROM CUSTOMER WHERE CITY='NEW YORK')