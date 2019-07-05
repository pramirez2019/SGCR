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
- "Login" textboxes and labels added
- "Login" button added
- "login" button functionality added
- "GetUser" function created on imp_data class 
- Users Table created on Database
- Stored Procedure "st_validateuser" created on database
- MDI.cs modified to show login form

02/06/2019 Release notes:

- "ABM Consorcio" Clean info button added
- "ABM Consorcistas" Clean info button added
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

16/06/2019 release notes:

- Stored procedure "st_updateCategRubros" to update service category created
- "imp_data": UpdateCategoria to update existing category on database
- "ABMCategorias" Update button functionality implemented(to update a category)
- "ABMCategorias" textboxes no info functionality implemented (If the textboxes are incomplete, they will change to red. If they textboxes are complete, they will change to blank again)
- "ABM Consorcistas" search consorcista button functionality implemented(to find a consorcista)
- "imp_data": GetConsorcista to get Consorcista by name
- Stored procedure "st_SearchConsorcista" to update service category created

27/06/2019 release notes:

- Stored procedure "st_deleteCategRubros" to delete service category created
- "ABMCategorias" delete button functionality (to delete a category)
- "imp_data": DeleteCategoria to delete existing category on database
- Modify "c_name" and "c_description" name columns to "c_name_categ" and "c_description_categ" on Categ_rubros database done
- Store procedure "st_InsertCategRubro" updated with new column names. 
- Update code for Add category button fuctionality with new name columns and check done
- "imp_data": AddCategRubro to add a new category updated with new parameters
- Stored procedure "st_searchCategRubro" updated with new column names. 
- Stored procedure "st_updateCategRubros" updated with new column names.
- "imp_data": UpdateCategoria to update existing category on database updated with new parameters

05/07/2019 release notes:

- "ABM Consorcistas" update button functionality (to update a consorcista)
- "imp_data": UpdateConsorcista to update existing Consorcista on database
- Stored procedure "st_updateConsorcista" to update Consorcista created
- "ABM Consorcistas" delete button functionality (to update a consorcista)
- Stored procedure "st_deleteConsorcista" to delete Consorcista created
- "imp_data": DeleteConsorcista to delete existing Consorcista on database


Next changes:

- Create "services" table
- Link services with categories
- Start calculations
 
