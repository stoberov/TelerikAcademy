# Database Systems - Overview

### _Homework_

1.  What database models do you know?
1.  Which are the main functions performed by a Relational Database Management System (RDBMS)?
1.  Define what is "table" in database terms.
1.  Explain the difference between a primary and a foreign key.
1.  Explain the different kinds of relationships between tables in relational databases.
1.  When is a certain database schema normalized?
    - What are the advantages of normalized databases?
1.  What are database integrity constraints and when are they used?
1.  Point out the pros and cons of using indexes in a database.
1.  What's the main purpose of the SQL language?
1.  What are transactions used for?
    - Give an example.
1.  What is a NoSQL database?
1.  Explain the classical non-relational data models.
1.  Give few examples of NoSQL databases and their pros and cons.

## _Solutions_
#### 1.  _What database models do you know?_
A database model is a type of data model that determines the logical structure of a database and fundamentally determines in which manner data can be stored, organized, and manipulated. The most popular example of a database model is the relational model, which uses a table-based format.

##### **_Main Types_**
 - **Hierarchical (Tree)** - A hierarchical database model is a data model in which the data is organized into a tree-like structure. The data is stored as records which are connected to one another through links. A record is a collection of fields, with each field containing only one value. The entity type of a record defines which fields the record contains.
 - **Network (Graph)** - The network model is a database model conceived as a flexible way of representing objects and their relationships. Its distinguishing feature is that the schema, viewed as a graph in which object types are nodes and relationship types are arcs, is not restricted to being a hierarchy or lattice.
 - **Relational (Table)** - In the relational model of a database, all data is represented in terms of tables, grouped into relations. A database organized in terms of the relational model is a relational database.The purpose of the relational model is to provide a declarative method for specifying data and queries: users directly state what information the database contains and what information they want from it, and let the database management system software take care of describing data structures for storing the data and retrieval procedures for answering queries.
 - **Object-oriented** - An object database (also object-oriented database management system) is a database management system in which information is represented in the form of objects as used in object-oriented programming. Object databases are different from relational databases which are table-oriented. Object-relational databases are a hybrid of both approaches.

#### 2.  _Which are the main functions performed by a Relational Database Management System (RDBMS)?_

Relational Database Management Systems (RDBMS) manage data stored in tables. RDBMS systems typically implement:
* Creating / altering / deleting tables and relationships between them (database * schema)
* Adding, changing, deleting, searching and retrieving of data stored in the tables
* Support for the SQL language
* Transaction management (optional)

#### 3.  _Define what is "table" in database terms._
 Database tables consist of data, arranged in rows and columns. All rows have the same structure. Columns have name and type (number, string, date, image, or other). They can be used to both store and display data in a structured format.

#### 4.  _Explain the difference between a primary and a foreign key._
**Primary Key:**
-  Primary key is a column of the table that uniquely identifies its rows (usually it is a number).
- Two records (rows) are different if and only if their primary keys are different.
- The primary key can be composed by several columns (composite primary key).
- Primary Key can't accept null values.
- There can only be one Primary key in a table.

**Foreign Key:**
- Foreign key is a field in the table that is primary key in another table.
- Foreign key can accept multiple null values.
- There can be many foreign keys in a table.

#### 5.  _Explain the different kinds of relationships between tables in relational databases._
By using relationships we avoid repeating data in the database. Relationships have multiplicity:
* **One-to-Many (Many-to-One)** - The primary key table contains only one record that relates to none, one, or many records in the related table. This relationship is similar to the one between child and a parent. The child has only one mother, but the mother may have several children.
* **Many-to-Many** - Each record in both tables can relate to any number of records (or no records) in the other table. For instance, if you have several siblings, so do your siblings (have many siblings). Many-to-many relationships require a third table, known as an associate or linking table, because relational systems can't directly accommodate the relationship.
* **One-to-One** - Both tables can have only one record on either side of the relationship. Each primary key value relates to only one (or no) record in the related table. They're like spouses—you may or may not be married, but if you are, both you and your spouse have only one spouse. Used to model inheritance between tables.

#### 6.  _When is a certain database schema normalized? What are the advantages of normalized databases?_
Normalization is the process of removing redundant data from your tables in order to improve storage efficiency, data integrity and scalability. This improvement is balanced against an increase in complexity and potential performance losses from the joining of the normalized tables at query-time.

There are two goals of the normalization process:
- eliminating redundant data (for example, storing the same data in more than one table)
- ensuring data dependencies make sense (only storing related data in a table).

Both of these are worthy goals as they reduce the amount of space a database consumes and ensure that data is logically stored.

##### **_Advantages of normalization:_**
- More efficient data structure.
- Avoid redundant fields or columns.
- More flexible data structure i.e. we should be able to add new rows and data values easily
- Better understanding of data.
- Ensures that distinct tables exist when necessary.
- Easier to maintain data structure i.e. it is easy to perform operations and complex queries can be easily handled.
- Minimizes data duplication.
- Close modeling of real world entities, processes and their relationships.

#### 7.  _What are database integrity constraints and when are they used?_
Data integrity refers to maintaining and assuring the accuracy and consistency of data over its entire life-cycle, and is a critical aspect to the design, implementation and usage of any system which stores, processes, or retrieves data.
##### **_Types of Integrity Constraints:_**
* **Primary key constraint** - ensures that the primary key of a table has unique value for each table row
* **Unique key constraint** - ensures that all values in a certain column (or a group of columns) are unique
* **Foreign key constraint** - ensures that the value in given column is a key from another table
* **Check constraint** - ensures that values in a certain column meet some predefined condition

#### 8.  _Point out the pros and cons of using indexes in a database._
##### **_Pros_**
Index is used for quick access to a database table specific information.
They speed up searching of values in a certain column or group of columns. Database indices are usually implemented as B-trees. Indices can be built-in the table (clustered) or stored externally (non-clustered).

##### **_Cons_**
Too much indices will affect the speed of update and insert, so indices may be best suited for frequently updated tables. There is little benefit of using them for small tables (less than 50,000 rows).

##### **_In short:_**
The index takes up disk space and reduces Add, Delete, and Update speed, but in most cases the speed advantages of indexes for data retrieval greatly exceed these inconveniences.

#### 9.  _What's the main purpose of the SQL language?_
SQL (Structured Query Language) is a standardized declarative language for manipulation of relational databases. The SQL language supports:
- Creating, altering, deleting tables and other objects in the database
- Searching, retrieving, inserting, modifying and deleting table data (rows)

Although most database systems use SQL, most of them also have their own additional proprietary extensions that are usually only used on their system. However, the standard SQL commands such as "SELECT", "INSERT", "Update", "DELETE", "CREATE" and "DROP" can be used to accomplish almost everything that one needs to do with a database.

#### 10.  _What are transactions used for? Give an example._
Transactions are a sequence of database operations which are executed as a single unit:
- Either all of them execute successfully
- Or none of them is executed at all

Transactions thus guarantee the consistency and the integrity of the database.

**_Example:_** A bank transfer from one account into another (withdrawal + deposit). If either the withdrawal or the deposit fails the entire operation should be cancelled.

#### 11.  _What is a NoSQL database?_
A NoSQL ("non SQL" or "not only SQL") database provides a mechanism for storage and retrieval of data that is modeled in means other than the tabular relations used in relational databases, whilst still supporting CRUD operations, indexing, querying, concurrency and transactions. NoSQL databases are increasingly used in big data and real-time web applications, as they are highly optimized for append / retrieve, and thus have great performance and scalability. The particular suitability of a given NoSQL database depends on the problem it must solve.

#### 12.  _Explain the classical non-relational data models._
* **Document model**
    - The central concept of a document model is the notion of a "document". While each document-oriented database implementation differs on the details of this definition, in general, they all assume that documents encapsulate and encode data (or information) in some standard formats or encodings. Encodings in use include XML, YAML, and JSON, as well as, binary forms like BSON.
    - Documents are addressed in the database via a unique key that represents that document. One of the other defining characteristics of a document-oriented database is that in addition to the key lookup performed by a key-value store, the database offers an API or query language that retrieves documents based on their contents.
    - Compared to relational databases, for example, collections could be considered analogous to tables and documents analogous to records. But they are different: every record in a table has the same sequence of fields, while documents in a collection may have fields that are completely different.
    - Examples: MongoDB, CouchDB, etc.


* **Key-value model**
    - Key-value model use the associative array (a.k.a. Dictionary in C#) as their fundamental data model. In this model, data is represented as a collection of key-value pairs, such that each possible key appears at most once in the collection.
    - The Key-value model is one of the simplest non-trivial data models, and richer data models are often implemented on top of it. The key-value model can be extended to an ordered model that maintains keys in lexicographic order. This extension is powerful, in that it can efficiently process key ranges.
    - Key-value model can use consistency models ranging from eventual consistency to serializability. Some support ordering of keys. Some maintain data in memory (RAM), while others employ solid-state drives or rotating disks.
    - Examples: Oracle NoSQL Database, Redis, etc.


* **Hierarchical key-value model**
    - This data model allows elements to link and be linked by several other elements thus constructing a hierarchical structure. Links usually have additional properties to describe the relation between elements.


* **Wide-column model**
    - Wide-column model takes a hybrid approach mixing the declarative characteristics game of relational databases with the key-value pair based and totally variables schema of key-value stores. Wide Column databases stores data tables as sections of columns of data rather than as rows of data.
    - Examples: Cassandra, HBase, Vertica, etc.


* **Object model**
    - Object-oriented database management systems (OODBMSs) combine database capabilities with object-oriented programming language capabilities. They allow object-oriented programmers to develop the product, store them as objects, and replicate or modify existing objects to make new objects within the OODBMS. Because the database is integrated with the programming language, the programmer can maintain consistency within one environment, in that both the OODBMS and the programming language will use the same model of representation.
    - Some object-oriented databases are designed to work well with object-oriented programming languages such as Delphi, Ruby, Python, Perl, Java, C#, Visual Basic .NET, C++, Objective-C.
    - Examples: Cache, Perst, Shoal, etc.

#### 13.  _Give a few examples of NoSQL databases and their pros and cons._
* **MongoDB**
    * **Pros**
        * Schema-less. If you have a flexible schema, this is ideal for a document store like MongoDB. This is difficult to implement in a performant manner in RDBMS.
        * Ease of scale-out. Scale reads by using replica sets. Scale writes by using sharding (auto balancing).
        * Cost. MongoDB is free and can run on Linux.
        * You can choose what level of consistency you want depending on the value of the data.
    * **Cons**
        * Data size in MongoDB is typically higher due to e.g. each document has field names stored it.
        * Less flexibility with querying.
        * No support for transactions - certain atomic operations are supported, at a single document level.
        * Less up to date information available/fast evolving product.


* **Redis**
    * **Pros**
        * Stores data in a variety of formats: list, array, sets and sorted sets.
        * Multiple commands at once.
        * Blocking reads - it will wait until another process writes data to the cache.
        * Mass insertion of data to prime a cache.
        * Partitions data across multiple redis instances.
        * Can back data to disk.
    * **Cons**
        * Super complex to configure - requires consideration of data size to configure well.
        * Lots of server administration for monitoring and partitioning and balancing.


* **Cassandra**
    * **Pros**
        * Cassandra is solving the problem of distributed and scalable systems, and it's built to cope with data management challenges of modern business.
        * Cassandra is decentralized system - there is no single point of failure, if minimum required setup for cluster is present - every node in the cluster has the same role, and every node can service any request. Replication strategies can be configured. It is possible to add new nodes to server cluster very easy. Also, if one node fails, data can be retrieved from some of the other nodes (redundancy can be tuned). It is especially suitable for multiple data-center deployment, redundancy, failover and disaster recovery, with possibility of replication across multiple data centers.
    * **Cons**
        * There is no referential integrity - there is no concept of JOIN connections in Cassandra.
        * Querying options for retrieving data are very limited.
        * There is no things like ORDER BY, GROUP BY.
