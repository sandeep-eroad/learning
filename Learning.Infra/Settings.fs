namespace Learning.Infra.Settings

open SimpleMigrations
​
module Main = 
    [<Migration(1L, "Init Database")>]
    type InitDatabase() =
        inherit Migration()
    ​
        override this.Up() =
            this.Execute("""
                create table persons(
                    id uuid not null primary key,
				    name varchar(255)
                );
            """)
    ​
        override this.Down() =
            this.Execute("""
                drop table persons;
            """)