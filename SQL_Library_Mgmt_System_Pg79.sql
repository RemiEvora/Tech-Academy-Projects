CREATE DATABASE db_library; 

USE db_library;


/*======== TABLE 'BOOK' CONSTRUCTION (COMPLETE) =========*/ 
CREATE TABLE tbl_book (
	book_bookid INT PRIMARY KEY NOT NULL, 
	book_title VARCHAR (100) NOT NULL,
	book_publishername VARCHAR (70) NOT NULL  
);


SELECT * FROM tbl_book;

/*======== TABLE 'BOOK' DATA INSERT (COMPLETE) =========*/ 
INSERT INTO tbl_book 
	(book_bookid, book_title, book_publishername)
	VALUES 

	('6000','The Lost Tribe','ThomasReuters'),('6001','Odd Thomas','ThomasReuters'),
	('6002','Phantoms','ThomasReuters'),('6003','Forever Odd','ThomasReuters'),
	('6004','Rising Sands','ThomasReuters'), ('6005','Between the Raindrops','ThomasReuters'),
	('9000','Maze Runner','Pearson'),('9001','The Death Cure','Pearson'), 
	('10000','Storm Front','Random House'),('10001','Grave Peril','Random House'),
	('10002','Summer Knight','Random House'),('10003','Dead Beat','Random House'), 
	('10004','Proven Guilty','Random House'),('10005','Turn Coat','Random House'),
	('2000','American Gods','Viking Press'), ('2001','Neverwhere','Viking Press'),
	('2002','Good Omens','Viking Press'), ('4000','Already Dead','Pearson'),
	('4001','No Dominion','Pearson'),('4002','Every Last Drop','Pearson'), 
	('3000','The Medusa Chronicles','Random House'),('3001','Beyond the Aquila Rift','Random House'),
	('3002','Revelation Space','Random House'),('3003','The Prefect','Random House'),
	('7000','Something Wicked This Way Comes','Harper Collins'),('7001','Fahrenheit 451','Harper Collins'),
	('7002','From the Dust Returned','Harper Collins'), ('7003','The Sound of Thunder','Harper Collins'),
	('8000','Web Mage','Harper Collins'),('8001','Broken Blade','Harper Collins'),
	('8002','Blade Reforged','Harper Collins'),('8003','Blades in Shadow','Harper Collins'),
	('1000','IT','Viking Press'),('1001','The Green Mile','Viking Press'),
	('1002','The Talisman','Viking Press'),('1003','Thinner','Viking Press'),
	('1004','11/22/63','Viking Press'), ('1005','Nightmares & Dreamscapes','Viking Press'),
	('5000','Washington and Caesar','Random House'),('5001','The Red Knight','Random House'),
	('5002','The Fell Sword','Random House')
;





/*======= TABLE 'BOOK AUTHORS' CONSTRUCTION (COMPLETE) ========*/ 
CREATE TABLE tbl_bookauthors (
	bookauthors_bookid INT PRIMARY KEY NOT NULL,
	bookauthors_authorname VARCHAR (70)  NOT NULL
);


SELECT * FROM tbl_bookauthors;

/*======= TABLE 'BOOK AUTHORS' DATA INSERT (COMPLETE) ========*/
INSERT INTO tbl_bookauthors 
	(bookauthors_bookid, bookauthors_authorname)
	VALUES
	('1000','Stephen King'),('1001','Stephen King'),('1002','Stephen King'),
	('1003','Stephen King'),('1004','Stephen King'),
	('2000','Neil Gaiman'),('2001','Neil Gaiman'),('2002','Neil Gaiman'),
	('3000','Alastair Reynolds'),('3001','Alastair Reynolds'),('3002','Alastair Reynolds'),
	('3003','Alastair Reynolds'),
	('4000','Charlie Huston'),('4001','Charlie Huston'),('4002','Charlie Huston'),
	('5000','Christian Cameron'),('5001','Christian Cameron'),('5002','Christian Cameron'),
	('6000','Dean Koontz'),('6001','Dean Koontz'),('6002','Dean Koontz'),
	('6003','Dean Koontz'),('6004','Dean Koontz'),
	('7000','Ray Bradbury'),('7001','Ray Bradbury'),('7002','Ray Bradbury'),
	('7003','Ray Bradbury'),
	('8000','Kelly McCullough'),('8001','Kelly McCullough'),('8002','Kelly McCullough'),
	('8003','Kelly McCullough'),
	('9000','James Dashner'),('9001','James Dashner'),
	('10000','Jim Butcher'),('10001','Jim Butcher'),('10002','Jim Butcher'),
	('10003','Jim Butcher'),('10004','Jim Butcher'),('10005','Jim Butcher')	
;




/*======= TABLE 'PUBLISHER' CONSTRUCTION (COMPLETE) ========*/ 
CREATE TABLE tbl_publisher (
	publisher_name VARCHAR (70) PRIMARY KEY NOT NULL,
	publisher_address VARCHAR (255) NOT NULL, 
	publisher_phone VARCHAR (50) NOT NULL
); 	  

SELECT * FROM tbl_publisher;

/*======= TABLE 'PUBLISHER' DATA INSERT (COMPLETE)========*/
INSERT INTO tbl_publisher 
	(publisher_name, publisher_address, publisher_phone)
	VALUES 
	('ThomasReuters','1 Reuters Dr, Sacramento, CA 94203','916-717-5201'),
	('Random House','105 Random Rd, Denver, CO 80014','303-123-0303'),
	('Viking Press','5575 Longson Blvd, Chicago, IL 60506', '312-588-1231'),
	('Pearson','802 Orchard Blvd, Bangor, ME 03901','207-202-2010'),
	('Harper Collins','1662 Harp Rd, Tempe, AZ 85202','480-129-9219')
;	



/*======= TABLE 'BOOK LOANS' CONSTRUCTION (COMPLETE) ========*/ 
CREATE TABLE tbl_bookloans (
	bookloans_bookid INT NOT NULL,
	bookloans_branchid INT NOT NULL,   
	bookloans_cardno VARCHAR(10) NOT NULL,   
	bookloans_dateout DATE NOT NULL,
	bookloans_duedate DATE NOT NULL 
); 	 

SELECT * FROM tbl_bookloans;

/*======= TABLE 'BOOK LOANS' DATA INSERT (COMPLETE) ========*/
INSERT INTO tbl_bookloans 
	(bookloans_bookid, bookloans_branchid, bookloans_cardno, bookloans_dateout, bookloans_duedate)
	VALUES
	('3002','102','joshe0000','2018-07-05','2018-07-19'),('6003','102','joshe0000','2018-07-05','2018-07-19'),
	('1000','104','tohan0000','2018-07-02','2018-07-16'),('1004','104','tohan0000','2018-07-02','2018-07-16'),('1005','104','tohan0000','2018-07-02','2018-07-16'),('2001','104','tohan0000','2018-07-02','2018-07-16'),('6002','104','tohan0000','2018-07-02','2018-07-16'),('5000','104','tohan0000','2018-07-02','2018-07-16'),('5001','104','tohan0000','2018-07-02','2018-07-16'),
	('10000','103','alcoo0000','2018-07-01','2018-07-15'),('10003','103','alcoo0000','2018-07-01','2018-07-15'),
	('6003','104','brant0000','2018-07-10','2018-07-24'),('7002','104','brant0000','2018-07-10','2018-07-24'),('10004','104','brant0000','2018-07-10','2018-07-24'),
	('4002','104','jaand0000','2018-07-07','2018-07-21'),('10000','104','jaand0000','2018-07-07','2018-07-21'),('10004','104','jaand0000','2018-07-07','2018-07-21'),
	('3000','101','yushe0000','2018-07-09','2018-07-23'),('4000','101','yushe0000','2018-07-09','2018-07-23'),('4001','101','yushe0000','2018-07-09','2018-07-23'),
	('4001','103','jafre0001','2018-07-10','2018-07-24'),('4002','103','jafre0001','2018-07-10','2018-07-24'),('7002','103','jafre0001','2018-07-10','2018-07-24'),
	('1002','100','jesho0000','2018-06-28','2018-07-12'),('2000','100','jesho0000','2018-06-28','2018-07-12'),('2002','100','jesho0000','2018-06-28','2018-07-12'),('7001','100','jesho0000','2018-06-28','2018-07-12'),('7002','100','jesho0000','2018-06-28','2018-07-12'),
	('7001','101','amchu0000','2018-06-30','2018-07-14'),('10004','101','amchu0000','2018-06-30','2018-07-14'),('10005','101','amchu0000','2018-06-30','2018-07-14'),
	('8000','100','hemci0000','2018-07-01','2018-07-15'),('8001','100','hemci0000','2018-07-01','2018-07-15'),('10001','100','hemci0000','2018-07-01','2018-07-15'),('10005','100','hemci0000','2018-07-01','2018-07-15'),
	('1000','100','katom0000','2018-07-05','2018-07-19'),('2000','100','katom0000','2018-07-05','2018-07-19'),('3001','100','katom0000','2018-07-05','2018-07-19'),('3003','100','katom0000','2018-07-05','2018-07-19'),('10005','100','katom0000','2018-07-05','2018-07-19'),
	('2000','102','mahal0000','2018-06-30','2018-07-14'),('10000','102','mahal0000','2018-06-30','2018-07-14'),('10001','102','mahal0000','2018-06-30','2018-07-14'),('10002','102','mahal0000','2018-06-30','2018-07-14'),('10004','102','mahal0000','2018-06-30','2018-07-14'),('7000','102','mahal0000','2018-06-30','2018-07-14'),('7001','102','mahal0000','2018-06-30','2018-07-14'),
	('1001','101','jejon0000','2018-07-10','2018-07-24'),('5001','101','jejon0000','2018-07-10','2018-07-24'),('5002','101','jejon0000','2018-07-10','2018-07-24'),
	('9000','102','caoh0000','2018-07-07','2018-07-21'),('9001','102','caoh0000','2018-07-07','2018-07-21'),
	('1001','104','jaflo0000','2018-06-29','2018-07-13'),
	('6000','100','jafre0000','2018-07-10','2018-07-24'),('9000','100','jafre0000','2018-07-10','2018-07-24')
;

/*======= TABLE 'BOOK COPIES' CONSTRUCTION (COMPLETE) ========*/
CREATE TABLE tbl_bookcopies (
	bookcopies_bookid INT NOT NULL,
	bookcopies_branchid INT NOT NULL,
	bookcopies_noofcopies INT NOT NULL
); 	 



SELECT * FROM tbl_bookcopies; 
/*======= TABLE 'BOOK COPIES' DATA INSERT (COMPLETE) ========*/
INSERT INTO tbl_bookcopies
	(bookcopies_bookid, bookcopies_branchid, bookcopies_noofcopies) 
	VALUES 
	('1000','100','2'), ('1000','102','2'),('1000','103','2'),
	('1001','101','3'), ('1001','104','2'), 
	('1002','100','3'),('1002','103','2'),
	('1003','100','2'),('1003','101','2'),('1003','102','2'),
	('1004','101','2'),('1004','103','2'),('1004','104','2'),
	('1005','102','2'),('1005','104','2'),
	('2000','100','2'),('2000','102','2'),('2000','103','2'),
	('2001','101','2'),('2001','104','3'),
	('2002','100','3'),('2002','104','2'),
	('3000','101','2'),
	('3001','100','2'), ('3001','103','2'),
	('3002','102','2'),
	('3003','100','2'),
	('4000','101','2'),('4000','102','2'),
	('4001','101','2'),('4001','102','2'),('4001','103','2'),
	('4002','103','2'),('4002','104','2'),
	('5000','104','2'),
	('5001','101','2'),('5001','102','2'),('5001','104','2'),
	('5002','100','2'),('5002','101','2'),
	('6000','100','2'),('6000','101','2'),
	('6001','103','2'),
	('6002','103','2'),('6002','104','2'),
	('6003','102','3'),('6003','104','3'),
	('6004','100','2'),('6004','101','2'),('6004','103','2'),
	('7000','102','2'),
	('7001','100','2'),('7001','101','2'),('7001','102','2'),
	('7002','100','2'),('7002','103','2'),('7002','104','2'),
	('7003','101','2'),('7003','102','2'),('7003','102','2'),
	('8000','100','2'),
	('8001','100','2'),
	('8002','100','2'),
	('8003','100','2'),('8003','104','2'),
	('9000','100','2'),('9000','102','2'),
	('9001','102','2'),
	('10000','102','2'),('10000','103','2'),('10000','104','2'),
	('10001','100','2'),('10001','102','2'),
	('10002','102','2'),
	('10003','103','2'),
	('10004','101','2'),('10004','102','2'),('10004','104','2'),
	('10005','100','2'),('10005','101','2'),('10005','103','2')
;




/*======= TABLE 'LIBRARY BRANCH' CONSTRUCTION (COMPLETE) ========*/
CREATE TABLE tbl_librarybranch (
	librarybranch_branchid INT PRIMARY KEY NOT NULL,
	librarybranch_branchname VARCHAR (70) NOT NULL, 
	librarybranch_address VARCHAR (255) NOT NULL
); 	 


SELECT * FROM tbl_librarybranch;
/*======= TABLE 'LIBRARY BRANCH' DATA INSERT (COMPLETE) ========*/
INSERT INTO tbl_librarybranch
	(librarybranch_branchid, librarybranch_branchname, librarybranch_address)
	VALUES 
	('100','Central','233 S Wacker Dr, Chicago, IL 60606'),
	('101','Sharpstown','1118 N Rodeo Dr, Sharpstown, IL 51234'),
	('102','Skokie','4905 Old Orchard Center, Skokie, IL 60077'),
	('103','Aurora','195 Fox Valley Center, Aurora, IL 60504'),
	('104','DeKalb','2500 Sycamore Rd, DeKalb, IL 60115')
;



/*======= TABLE 'BORROWER' CONSTRUCTION (COMPLETE) ========*/
CREATE TABLE tbl_borrower ( 
	borrower_cardno VARCHAR (70) PRIMARY KEY NOT NULL, 
	borrower_name VARCHAR (70) NOT NULL, 
	borrower_address VARCHAR (255) NOT NULL, 
	borrower_phone VARCHAR (20) NOT NULL 
); 



SELECT * FROM tbl_borrower;
/*======= TABLE 'BORROWER' DATA INSERT (COMPLETE)========*/
INSERT INTO tbl_borrower
	(borrower_cardno, borrower_name, borrower_address, borrower_phone)
	VALUES 
	('tohan0000','Tom Hange','379 Lively St, Sharpstown, IL 51234','217-911-9119'), 
	('katom0000','Kazu Tomoya','801 Devon Ave, Chicago, IL 60007','312-509-2959'),
	('jaflo0000','Jane Flores','1652 Charlotte Ln, Carmel, IL 46033','618-208-0808'),
	('brant0000','Bruce Antikos','710 Armstrong Rd, Zionsville, IL 46077','463-123-4566'),
	('hemci0000','Henry McIvers','1552 Keyes Blvd, Glendale Hts, IL 60137','630-104-5698'),
	('jesho0000','Jennifer Shoemacher','157 Kings Ct, Chicago, IL 60649','312-222-3333'),
	('yushe0000','Yuyan Shen','1257 Archer Ave, Sharpstown, IL 51234','217-119-1234'),
	('alcoo0000','Ali Cooper','1892 Enola Rd, Whitestown, IL 46075','463-175-0182'), 
	('jafre0000','Jake Freidman','1880 Rohlwing Rd, Mt Prospect, IL 60143','630-995-1212'), 
	('amchu0000','Amaya Chun','454 Medina Rd, Sharpstown, IL 51234','217-775-3921'),
	('joshe0000','John Shepard','177 Normandy Dr, Chicago, IL 60649','312-224-2662'),
	('mahal0000','Mary Halley','2552 N Pollen Rd, Skokie, IL 60077','847-590-9050'),
	('jaand0000','Jamie Anderson','225 Trinity Plaza, Zionsville, IL 46077','463-234-5687'),
	('jejon0000','Jean-Paul Jones','6573 N Ardmore Ave, Sharpstown, IL 51234','217-222-3985'),
	('jafre0001','Jackie Freud','4687 Laramie Rd, Carmel, IL 46033','618-445-3131'),
	('caoh0000','Candace Oh','5775 Busse Rd, Skokie, IL 60077','847-381-8989')
;	
