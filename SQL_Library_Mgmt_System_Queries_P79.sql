/* 

CREATE STORED PROCEDURES THAT WILL QUERY FOR EACH OF THE FOLLOWING QUESTIONS:
1. How many copies of the book titled "The Lost Tribe" are owned by the library branch whose name is "Sharpstown"?

2. How many copies of the book titled "The Lost Tribe" are owned by each library branch?

3. Retrieve the names of all borrowers who do not have any books checked out.

4. For each book that is loaned out from the "Sharpstown" branch and whose DueDate is today, retrieve the book title, the borrower's name, and the borrower's address.

5. For each library branch, retrieve the branch name and the total number of books loaned out from that branch.

6. Retrieve the names, addresses, and number of books checked out for all borrowers who have more than five books checked out.

7. For each book authored (or co-authored) by "Stephen King", retrieve the title and the number of copies owned by the library branch whose name is "Central".

Once you've completed this, add it to your GitHub.

*/ 


/* ============= QUERIES =================== */ 
/* ========================================= */ 


/* === QUERY 1 === */ 
-- 1. How many copies of the book titled "The Lost Tribe" are owned by the library branch whose name is "Sharpstown"?
SELECT 
	a1.bookcopies_bookid AS 'Book ID', a1.bookcopies_branchid AS 'Branch ID', a1.bookcopies_noofcopies AS '# of Copies', 
	a2.book_title AS 'Book Title', a3.librarybranch_branchname AS 'Branch Name' 
	FROM tbl_bookcopies a1
	INNER JOIN tbl_book a2 ON a2.book_bookid = bookcopies_bookid
	INNER JOIN tbl_librarybranch a3 ON a3.librarybranch_branchid = bookcopies_branchid
	WHERE book_title = 'The Lost Tribe' AND librarybranch_branchname = 'Sharpstown'
;


/* === QUERY 2 === */ 
--2. How many copies of the book titled "The Lost Tribe" are owned by each library branch?
SELECT 
	a1.bookcopies_bookid AS 'Book ID', a1.bookcopies_branchid AS 'Branch ID', a1.bookcopies_noofcopies AS '# of Copies', 
	a2.book_title AS 'Book Title', a3.librarybranch_branchname AS 'Branch Name' 
	FROM tbl_bookcopies a1
	INNER JOIN tbl_book a2 ON a2.book_bookid = bookcopies_bookid
	INNER JOIN tbl_librarybranch a3 ON a3.librarybranch_branchid = bookcopies_branchid
	WHERE book_title = 'The Lost Tribe'
;	 


/* === QUERY 3 === */ 
--3. Retrieve the names of all borrowers who do not have any books checked out.
/* ====
NOTE: Table Data assumes that borrowers are on record for a single date borrowing 
multiple books, returned them and have not borrowed since, all library patrons 
in this data set have been designed to have borrowed something at some point 
in time 
==== */ 
SELECT 
	a1.borrower_cardno AS 'Card No', a1.borrower_name AS 'Name',
	a2.bookloans_duedate AS 'Last Due Date' 
	FROM tbl_borrower a1
	INNER JOIN tbl_bookloans a2 ON a2.bookloans_cardno = borrower_cardno
	WHERE bookloans_duedate <= '2018-07-16'
;


/* === QUERY 4 === */ 
--4. For each book that is loaned out from the "Sharpstown" branch and whose DueDate is today, retrieve the book title, 
--the borrower's name, and the borrower's address.
/* ====
NOTE: Due to the data entered, there are no books borrowed from the Sharpstown Branch on 
the date that this query was created (2018-07-16).  
==== */
SELECT 
	borrower_name AS 'Name', borrower_address AS 'Address', 
	book_title AS 'Book Title'
	FROM tbl_borrower 
	INNER JOIN tbl_bookloans ON bookloans_cardno = borrower_cardno
	INNER JOIN tbl_book ON book_bookid = bookloans_bookid
	INNER JOIN tbl_librarybranch ON librarybranch_branchid = bookloans_branchid
	WHERE librarybranch_branchname = 'Sharpstown' 
	AND bookloans_duedate = '2018-07-16'
;

/* === QUERY 5 === */ 
--5. For each library branch, retrieve the branch name and the total number of books loaned out from that branch.
SELECT 
	librarybranch_branchname, COUNT(*) AS 'Total Books Loaned'
	FROM tbl_bookloans
	FULL OUTER JOIN tbl_librarybranch ON bookloans_branchid = librarybranch_branchid
	WHERE librarybranch_branchname IN ('Central', 'Sharpstown', 'Skokie', 'Aurora', 'DeKalb')
	GROUP BY librarybranch_branchname
;


/* === QUERY 6 === */ 
-- 6. Retrieve the names, addresses, and number of books checked out for all borrowers who have more than five books checked out.
SELECT 
	borrower_name, borrower_address, COUNT(bookloans_cardno) AS 'Number of Books'
	FROM tbl_borrower 
	FULL OUTER JOIN tbl_bookloans ON borrower_cardno = bookloans_cardno
	GROUP BY borrower_name, borrower_address
	HAVING COUNT (bookloans_cardno) > 5
;

/* === QUERY 7 === */ 
--7. For each book authored (or co-authored) by "Stephen King", retrieve the title and the number of copies owned by the library branch whose name is "Central".
SELECT 
	book_title AS 'Title', bookcopies_noofcopies AS 'No of Copies', 
	librarybranch_branchname AS 'Location'
	FROM tbl_book
	FULL OUTER JOIN tbl_bookcopies ON book_bookid = bookcopies_bookid
	FULL OUTER JOIN tbl_librarybranch ON bookcopies_branchid = librarybranch_branchid
	FULL OUTER JOIN tbl_bookauthors ON book_bookid = bookauthors_bookid
	WHERE bookauthors_authorname = 'Stephen King'
	AND librarybranch_branchname = 'Central' 
;

