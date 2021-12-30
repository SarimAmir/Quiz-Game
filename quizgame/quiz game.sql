create table questions
(
q_id int identity primary key,
q_question nvarchar(max) not null,
q_optionA nvarchar (max) not null,
q_optionB nvarchar (max) not null,
q_optionC nvarchar (max) not null,
q_optionD nvarchar (max) not null,
Q_CORRECTOPTION nvarchar(max) not null
)

create PROC insert_question
(
@q_question nvarchar(max),
@q_optionA nvarchar (max),
@q_optionB nvarchar (max),
@q_optionC nvarchar (max),  
@q_optionD nvarchar (max),
@Q_CORRECTOPTION nvarchar (max)
)
AS
BEGIN
INSERT INTO questions(q_question,q_optionA,q_optionB,q_optionC,q_optionD,Q_CORRECTOPTION)
VALUES (@q_question,@q_optionA,@q_optionB,@q_optionC,@q_optionD,@Q_CORRECTOPTION)

END 

EXECUTE insert_question 'What does “www” stand for in a website browser?','World Wide Web','Whole World Web','World of Wellness','Website World','World Wide Web'
EXECUTE insert_question 'How long is an Olympic swimming pool (in meters)?','40','45','50','60','50'
EXECUTE insert_question 'What countries made up the original Axis powers in World War II?','Spain,France and Portugal','England,Austrailia','Pakistan,Zimbabwe','Germany, Italy, and Japan','Germany, Italy, and Japan'
EXECUTE insert_question 'Which country do cities of Perth, Adelade & Brisbane belong to?','Austrailia','England','New zealand','Scotland','Austrailia'
EXECUTE insert_question 'What geometric shape is generally used for stop signs?','Octagon','Triangle','Circle','Pentgagon','Octagon'
EXECUTE insert_question 'What is cynophopia?','Fear of heights','Fear of snakes','Fear of water','Fear of Dogs','Fear of Dogs'
EXECUTE insert_question 'Who named the Pacific Ocean?','Sammy Nelson','Flinn Johnson','John Smith','Ferdinand Magellan','Ferdinand Magellan'
EXECUTE insert_question 'How many languages are written from right to left?','9','13','14','12','12'
EXECUTE insert_question 'What is the name of the biggest technology company in South Korea?','Nokia','Samsung','HTC','Xiaomi','Samsung'
EXECUTE insert_question 'Which animal can be seen on the Porsche logo?','Horse','Dragon','Snake','Elephant','Horse'
EXECUTE insert_question 'Who was the first woman to win a Nobel Prize (in 1903)?','Elizabeth Swan','Marie Qurie','Sharon Tate','Margot Johnson','Marie Qurie'
EXECUTE insert_question 'Worship of Krishna is observed by which Religious Faith?','Hinduism','Jewish','Catholics','Muslims','Hinduism'

select * from questions