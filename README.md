1.	Update Connection String  of the Database in ‘appsettings.json’

2.	Add Migration and Update Database to create Identity tables in Database

       (In the Package Manager Console, run:
            Add-Migration Initial ->Enter Key
            Update-Database  ->enter Key)
3.	Run the Project (using Swagger)
4.	Click Post   /api/auth/register -Try it OutEnter Valid Email and Password inside the (“ ”)-Execute

    Email :       Should be valid Email
    Password: minimum 6 characters with alpanumeric ,one nonalphanumeric,one Upper Case)
Eg:-
    {
  "email": "vb@example.com",
  "password": "String1*"
}
