create database WhoWantToBeAMillionaire
use WhoWantToBeAMillionaire

create table question
(
	QID nvarchar(50) primary key,
	Question nvarchar(50),
)

create table answer
(
	QID nvarchar(50) FOREIGN KEY REFERENCES question(QID),
	AID nvarchar(50) ,
	answerQuestion nvarchar(50),
	isCorrect bit --0 la false, 1 la true
	primary key (AID, QID)
)

insert into question values ('Q1', '1 + 1 = ?')
insert into answer values ( 'Q1','A1',  '2', 1)
insert into answer values ('Q1','A2','3', 0)
insert into answer values ('Q1','A3','4', 0)
insert into answer values ('Q1','A4','0', 0)

insert into question values ('Q2', '15 + 1 = ?')
insert into answer values ('Q2', 'A1', '10', 0)
insert into answer values ('Q2', 'A2', '15', 0)
insert into answer values ('Q2', 'A3','16', 1)
insert into answer values ('Q2', 'A4','12', 0)

insert into question values ('Q3', '1 + 2 = ?')
insert into answer values ('Q3','A1',  '2', 0)
insert into answer values ('Q3','A2','3', 1)
insert into answer values ('Q3','A3','4', 0)
insert into answer values ('Q3','A4', '0', 0)

insert into question values ('Q4', '1 - 1 = ?')
insert into answer values ('Q4','A1',  '2', 0)
insert into answer values ('Q4','A2','3', 0)
insert into answer values ('Q4','A3','4', 0)
insert into answer values ('Q4','A4','0', 1)

insert into question values ('Q5', '1 * 4 = ?')
insert into answer values ('Q5','A1','2', 0)
insert into answer values ('Q5','A2','3', 0)
insert into answer values ('Q5','A3','4', 1)
insert into answer values ('Q5','A4','0', 0)
