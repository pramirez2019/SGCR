SGCR is a Spanish system to manage building, add department owners, taxes, services and maintance. 


27/05/2019 Release notes:

- "Home" Form ABM Consorcistas button created
- "ABM Consorcio" Textboxes color validation completed (if the textboxes are blank, they change to red color)
- "ABM Consorcistas" Panel created
- "ABM Consorcistas" Back button functionality implemented (goes back to home form)
- "ABM Consorcistas" Search button functionality (brings Consorcio Name, Domicilio and CP)
- "ABM Consorcistas" Textboxes color validation completed (if the textboxes are blank, they change to red color)
- "Consorcista" Table created on Database
- Stored Procedure "st_insertConsorcista" created on database
- "AddConsorcista" function created on imp_data class
- "ABM Consorcistas" AltaBtn functionality to add new Consorcistas 

29/05/2019 Release notes:

- Login Form added
- Login textboxes and labels added
- Login button added
- login button functionality added
- "GetUser" function created on imp_data class 
- Users Table created on Database
- Stored Procedure "st_validateuser" created on database
- MDI.cs modified to show login form

02/06/2019 Release notes:

- "ABM Consorcio" Clean info button added
- "ABM Consorcista" Clean info button added
- "reset_controls" class created
- "reset" function created to clean controls on reset_controls class
- Clean info functionality created for "ABM Consorcio" and "ABM Consorcista"
- Tab order modified for "login" form

07/06/2019 Release notes:

- "login" cs: bool variable created to validate users. If statement changed to validate with bool variable.
- "imp_data": getuser method changed from string to bool to validate users.
- "ABMCategorias" form added and ControlBox to false
- "ABMCategorias" textboxes, labels and buttons added
- "ABMCategorias" Add button functionality implemented (Add new service category)
- "ABMCategorias" Back button functionality implemented (goes back to home form)
- "ABMCategorias" Search button functionality implemented(brings id Category, category name and category description )
- "ABMCategorias" Clean Info button functionality implemented(brings id Category, category name and category description )
- "imp_data": AddCategRubro to add a new category on database
- "imp_data": GetCategoria to add a new category on database
- "Categ_rubros" table created on database
- Stored procedure "st_InsertCategRubro" to insert service category created
- Stored procedure "st_searchCategRubro" to search service category created
 
 
