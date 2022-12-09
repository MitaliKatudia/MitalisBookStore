2022-10-28, 11:40am

Created an ASP .NET Core Application (Model-View-Controller)
Application Name - MitalisBookStore, Programmed by - Mitali Dinesh Katudia
Configured Individual Accounts authentication and HTTPS security, enabled Razor Runtime....
Created a text file called README.txt.....
Created a Git Repository named MitalisBookStore and added the project to Git

Part 1, 11:55am
Reviewing the files according to slides provided 
Commented out the SSL Port in launchSettings.json because of lab restrictions
Running the Application to check....
Everything looks perfect.....links working properly
Removed the option for requirecConfirmAccount in Startup.cs for identity user

Debugging....missed this step here
Added two breakpoints in HomeController.cs at IActionResult of index page and privacy page
Started debugging it, first with Index (Home) Page and then with Privacy Page.... successfull

Moving forward to Bootstrap for the look and feel of the application
Downloaded the'Sketch' theme from Bootswatch.com and replaced the bootstrap.css with the new code
Changed the reference from bootstrap.min.css in the _Layout.cshtml and linked to a new bootstrap.css 
removed some properties from text dark and in the footer class css 
Changed some layout settings in _Layout.cshtml and ran the application to check whether its working or not....
The application looks good and the header as well as footer matches the theme

Starting with 3rd Party tools and jQuery
Added additional 3rd party tools in the _Layout.cshtml some scripts and links to jquery and css
CSS:
<link rel="stylesheet" href="https://cdn.datatables.net/1.10.16/css/jquery.dataTables.min.css" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css" />

JS:
<script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
<script src="https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js"></script>
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js"></script>
<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
<script src="https://kit.fontawesome.com/e19c476714.js"></script>
Commiting the changes.... ending at 01:35pm

---------------------------------------------------------------------------------------------------------------------------
2022-10-29, 05:55pm

Pulled the repository to my personal device and started the application to check...everything okay..
Added a dropdown menu in _Layout.cshtml file....Rebuilt the project and ran again...
Well something is wrong..... it shows the button but not the content inside it...will have to figure out
Tried googling it but cannot find the solution....thought maybe because I didn't replace the css provided by professor
Replaced a different css and tried running the app....still not working....ending here for today
Commited changes to github... ended at 06:45pm

---------------------------------------------------------------------------------------------------------------------------
2022-10-31, 12:10pm

Rebuilt the application and ran to check how it works other than the dropdown....
Added a css display property of block and then also inline-block but it is still messing up....missing some class properties
<..... role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"> the remaining class properties for the dropdown nvigation
Changed the Dropdown name to 'Content Management'
Done....so far so good...commiting the changes to github

2022-10-31, 01:05pm

Moving towards Part 1.4 of adding projects in the application
Added 3 new projects in my application..... 1) MitalisBooks.DataAccess, 2)MitalisBooks.Models and 3)MitalisBooks.Utility
Copied the Data folder and pasted in the MitalisBooks.DataAccess project..... deleted the original folder
Installed a new package.... Microsoft.EntityFrameworkCore.Relational with the version 3.1.16
Oooommmyyyyygoddddddd.......deleted the migrations folder....
Installed an identity package to the project MitalisBooks.DataAccess and changed the namespace
Deleted the class files of all 3 new projects.....ending here at 01:48pm

---------------------------------------------------------------------------------------------------------------------------
2022-11-02, 08:37pm

Tried pulling my repository in my personal laptop but it does not show my 3 new projects
Deleted all projects and created an new one to test....
Had to change the path when creating the project inside the MitalisBookStore so that it gets stored inside the solution folder
Solved the error....will try doing for the other projects after sometime.... ending at 08:44pm

---------------------------------------------------------------------------------------------------------------------------
2022-11-03, 06:35pm

Started the application to check if everything is okay...
Well....everything crashed out....when I deleted the other projects, one had my data folder and now its deleted too...
I will have to start again by building the new application....ughhh

2022-11-03, 06:50pm

Built the new Application...
Deleted old files and repository and starting from scratch
Completed Part 1.1 (Review) and Part 1.2 (Debugging) of the Application
Did the Bootstrap Part again...
Took a small break to cook dinner...
Started at 08:10pm again...
Moving forward with Part 1.4 Adding Projects and Modifying...
Completing steps till the last time  application crashed...
Added new projects...commiting and pulling back application again to make sure there are no mistakes again....
Everything good so far.... running the application to check again....
Added new packages to the new projects....and commiting the changes...
Built the project mitalisBooks.DaaAccess and said it succeeded....
Moved the Models folder into MitalisBooks.Models and deleted original
Added project reference and changed namespace in ErrorViewModel.cs
Changed assembly references according to application in Startup.cs and ErrorViewModel

Took a small break for dinner....started at 10:10pm 
Added project references to the other projects and main project and added a class Static class called SD.cs in Utility project...


2022-11-04, 12:14am
Added an area in areas folder called customer and scaffolded it...also changed pattern mentioned in Startup.cs
Moved HomeController.cs in Areas/Customer/Controllers
Added steps according to the PPT in areas folder and did the changes but there having the issues when I run the application...
The browser shows the following error: 
"InvalidOperationException: The constraint reference 'Customer' could not be resolved to a type. 
Register the constraint type with 'Microsoft.AspNetCore.Routing.RouteOptions.ConstraintMap'."
Well....I did some surfing on the internet and found something to add in the Startup.cs file.....it kind of works for now...
Copied _ViewImports.cshtml and _ViewStart.cshtml inside Areas Customer folder...and changed the path toview the layout page...

2022-11-04, 01:17am
Added an area called Admin... deleted Models and Data folder and added _ViewImports.cshtml and _ViewStart.cshtml in its Views folder....
Deleted the controllers folder outside the areas folder...
Stating the application again to check.....commiting changes to github...
Part 1 of the assignment finished.....finallyyyyy I can go to bed....GoodNight....ending at 01:30am

---------------------------------------------------------------------------------------------------------------------------
2022-11-08, 01:05pm

Starting Part 2 of the Assignment
Part 2.1: Creating Database
Built the solution.... 4 successful
Changed Connection string to MitalisBookStore
Added a migration called AddInitialDatabase but showed the following error:
"Your target project 'MitalisBookStore' doesn't match your migrations assembly 'MitalisBooks.DataAccess'. 
Either change your target project or change your migrations assembly."
Changed the default project setting to MitalisBooks.DataAccess and ran the command again
This is my default created file name: 20221108181006_AddInitialDatabase.cs
Updated the Database from package manager console....
Error: Keyword not supported: 'databasemitalisbookstore;trusted_connection'.... I mistakenly erased the '=' in appsettings.json
Updated Database successfully.....
Checking for errors and run the application...... everything fine.....
Added a new Class Category.cs in MitalisBooks.Models and modified it....
Added Migration AddCategory to the database....
Updated the migration file in ApplicationDbContext.cs and added a using statement to use MitalisBooks.Models
Ran the command to PMC: Add-Migration AddCategory.... Error: The name 'AddCategory' is used by an existing migration.
Deleted the migration by running command: Remove-Migration.... and re-added the migration....
This is my migration for category created file name: 20221108185414_AddCategory.cs
Everything went successfull.....commiting changes to github....
Part 2.1 Complete...

Part 2.2: Repository, 02:00pm
Created Directory inside .DataAccess > Repository > IRepository > IRepository.cs (Interface)
Updated the IRepository.cs content to use on Category class for CRUD Operations.....
Implemented a class in Repository called Repository.cs and after modifying saw the potential fixes says Implement Interface....
Modified the code to create the constructors and dependency injections (DI)
Added two new files, an Interface - ICategoryRepository.cs and Class - Categoryrepository.cs
Reviewed the error in CategoryRepository.cs and implemented the interface to update and remaining modifications....
A lot of typing....taking a short break.....03:10pm

03:28pm
Build the solution, 2 successful and 2 up-to-date
Added an interface ISP_Call.cs and modified the code... installed the Dapper from implement interface to fix problems
Added a class SP_Call.cs and edited the methods... had an error on SqlConnection: Missing assembly reference
Added 'using Microsoft.Data.SqlClient;' in SP_Call.cs .....
Updated the methods implemented from ISP_Call.cs 
Similarly made the UnitOfWork,cs and IUnitOfWork.cs in MitalisBooks.DataAccess and updated the code
To make is accessible, registered in Startup.cs in CnfigureServices method
Had assembly reference errors... had to add these using statements: 
		using MitalisBooks.DataAccess.Repository.IRepository;
		using MitalisBooks.DataAccess.Repository;
Builing the solution... 2 succeede and 2 up-to-date.....
Completed Part 2.2 ....commiting changes to github.... ending at 05:05pm

---------------------------------------------------------------------------------------------------------------------------
2022-11-11, 03:50pm

Starting Part 2.3 - Category CRUD
Added a CategoryController.cs inside Areas/Admin/Controllers
Modified the code and added some using statements...
Had an error: "#endregion directive expected".....added '#endregion' at the end of the curly braces....
Added a Views folder called Category in Areas/Admin/Views
Added a empty razor view called Index.cshtml and edied the code provided by professor...
Ran the application by appending the URL: http://localhost:27253/Admin/Category....everything as it should be...
Did some layout changes by adding the category list in the dropdown list....reviewing it...
Modified the Index.cshtml to add icons in the category section...ran the application
Commented the code and added a category.js file inside wwwroot/js .....

Took a small break...back at 05:13pm
Added the Upsert method in CategoryController.cs and not adding the Upsert view page
Inserted code for the Upsert.cshtml 
Stuck with adding the partial view.... there is not the option of create partial view....will do some research......
Taking a break.....at 05:33pm 

---------------------------------------------------------------------------------------------------------------------------
2022-11-13, 03:45pm

Build the solution.....4 successful
I mistakenly added an empty razor view in the Index.cshtml file....have to delete it do again
Did the steps again and changed layout to get Category link in Dropdown
Repeated steps till Upsert.chtml again and ready to move forward

Added a Partial View called _CreateAndBackToListButton.cshtml and modified code
Another Partial view _EditAndbackToListButton.cshtml and added code along with @model razor statement
Modified the Upsert.cshtml file to different form models
Added the asp-action to the Index.cshtml page... lets run the application
Added the POST method to CategoryControlle.cs and 'void Save();' to IUnitOfWork.cs 
Removed _dbSaveChanges() from CategoryRepository.cs and  moved the _unitOfWork.Save() method....
Check the application.....the edit category page is not displaying... changed the @if(Model.Id != null) to@if(Model.Id != 0)
Lets try again.... something is not working properly.... taking a break at 05:10 pm

Got Back at 07:00pm
Edited the Upsert.cshtml code... there was typing mistake in IActionResult.....everything proper now....
When adding categories...it is going properly in the database but does not show on my categories page....trying to resolve it...
Closed the project and started again...successful
Added the API call for HttpDelete in CategoryController.cs along with inside category.js
Added the delete function code provided by sir in category.js
Lets run the application ....
Finished Part 2 of the Assignment....ending at 10:20pm

---------------------------------------------------------------------------------------------------------------------------
2022-11-20, 07:40pm

Starting Part 3 of the Assignment
Part 3.1 - Cover type CRUD
Added a class called CoverType.cs in .Models project and ID and Name as in Category.cs
Added an Interface called ICoverTypeRepository.cs and updated code accordingly....
Created new Repository class for CoverType Called CoverTypeRepository and modified code from CategoryRepository.cs
Updated IUnitOfWork.cs with code - ICoverTypeRepository CoverType { get; }
Updated UnitOfWork.cs with code - public ICoverTypeRepository CoverType { get; private set; }
Error: Your target project 'MitalisBookStore' doesn't match your migrations assembly 'MitalisBooks.DataAccess'. Either change your target project or change your migrations assembly.
Changed the project type to MitalisBooks.DataAccess and added migration again
AddCoverType migration file name: 20221121012057_AddCoverType.cs and updated database....
Commiting changes to github....taking a break at 08:25pm

Back at 11:15pm
Starting to create CRUD pages for CoverType 
Added CoverTypeController.cs in Admin and modified code...
Created a new folder named CoverType in Admin/Vies and added View Template called Index.cshtml....modified code
Viewed the page by running the appication...it is taking category table data....
Added a new file called coverType.js and added code from category.js and modified it.....
Creating an Upsert.cs page for CoverType.....edited the code similar to Category's Upsert.cs
Everything works properly....the cover types can be created, edited and deleted....yuppp
Commiting changes to github....

2022-11-21, 12:05am
Part 3.2 - Product CRUD
Starting Product CRUD 
Created a class called Product.cs in .Models project and defined properties given by professor....
Added reference in ApplicationDbContext.cs and starting migration
File name for Product migration - 20221121053007_AddProduct.cs
Updated the database and can see the table in SQL SOE.....
Actually I mistakenly forgot to add property ImageUrl in Product.cs and when I tried redoing the validation it added property too...
It was not updating so I removed migration and re-added the mgration of AddProduct along with validation required for other 3 properties
Created ProductRepository.cs and IProductRepository.cs along with modifying the code necessary.....
Added references to UnitOfWork.cs and IUnitOfWork.cs and Commiting to github 
Ending here for now..... going to bed at 12:55am

---------------------------------------------------------------------------------------------------------------------------
2022-11-21, 04:20pm
Part 3.2 - Product CRUD (2)
Created a Product Controller.....and added IWebHostEnvironment call with its using statement 
Added a ViewModel Class called ProductVM.cs in .Models project and modify the code with select list for category and coverType
Error: Misiing an assembly reference.... adding package Microsoft.AspNetCore.Mvc.ViewFeatures from the package manager solution
Modified the ProductController.cs so IActionResult Upsert calls to ProductVM view model.....commented it for now....
In ProductController.cs modified the API call to include the Category and CoverType properties
Created a View in Admin/Views/Product folder called Index.cshtml and modified the code from Category's Index.cshtml
Added a product.js javascript in wwwroot folder and modified the table contents....
Added Product link in _Layout.cshtml dropdown menu.....lets run the application.....
Had an exception in Repository.cs and a PopUp for table data something......else table contents are displayed properly....
Section 2 over...ending here for today....commiting to github...05:57pm

---------------------------------------------------------------------------------------------------------------------------
2022-11-23, 01:15pm
Part 3.2 - Product CRUD (3)
Added a view called Upsert.cs in Admin/Views/Product and modified code provided by professor....
Went to tiny.cloud and created an account.... added Domain Name: mitalikatudia.com
Initialized and added a function to validate input and if empty, display an alert in Upsert.cs
Lets run thee application to check desired outcome.... it was not locating the upsert page because the method was commented...
Created the directory as wwwroot/images/products
Uncommented the method and configured the Product Upsert Action Method.....something is wrong....
When uncomment the upsert method in ProductController.cs but it says cannot invert int type to bool....
Ending for now....commiting to github....at 02:15pm

---------------------------------------------------------------------------------------------------------------------------
2022-11-24, 05:30pm

Well minor error....cross-checked the entire code and there was an extra equalTo needeed....everything works good....
Run the application...the database ajax error is still coming but otherwise works perfect.... the data when submitted goes inside database...
Closing the application...good to show in lab tomorrow...ending at 06:00pm

---------------------------------------------------------------------------------------------------------------------------
2022-11-25, 05:00pm

A disaster had occured :(  ......  all my projects were created locally and does not have reference or are not linked to my github repository....
Everything till now works perfectly fine according to professor's requirements.....
Sir adviced me to make new repository as well as project because this can be important in further steps of building the project....
Deleting this project as well as git repository and starting from scratch..... 

05:20pm
Created New Project called MitalisBookStore and placed '.sln' file in seperate folder.....
Starting Assignment part 1 again as per instructions.....
Changed Bootstrap theme from "Sketchy" to "Lux" because sketchy looked tacky 😉 
Commiting bootstrap theme to github......
Part 1.4 - Adding Projects to github.....called MitalisBooks.DataAccess, MitalisBooks.Models, and MitalisBooks.Utility
Modified the projects accordingly and built them individually.....
Added an area called Customer with modifying it to see the HomePages and everything....
Added an area called Admin and added view files....Part 1 of the Assignment complete

06:30pm
Starting Part 2 of the assignment again as per instructions.....
New Migration File for Initial Database: 20221125234308_AddInitialDatabase.cs
New Migration File for Adding Category: 20221125235103_AddCategory.cs
New Migration File for Adding CoverType: 20221126010741_AddCoverType.cs
New Migration File for Adding Product: 20221126060757_AddProduct.cs
Added all the files Required in Repository and IRepository Folders
Moving forward with Category CRUD
Created Controller and View Pages to display the application accordingly.....
Finished Part 2 of the Assignment.....

07:38pm
Starting Part 3 of the assignment again as per instructions.....
CoverType CRUD Pages....
Added CoverTypeRepository and ICoverTypeRepository along with necessary files to create a database file and table....
Added link to layout dropdown as needed and run the application....everything perfect.....
Taking a break....commiting to github and closing at 08:12pm

---------------------------------------------------------------------------------------------------------------------------
2022-11-26, 01:05am

Starting Product Object and its CRUD Pages....
Added Product to database by creading a class in .Models project....
Added ProductRepository and IProductRepository and also the References to UnitOfWork and IUnitOfWork files...
Created ProductController and product.js to the project and required View files...
Ran the application....works the same as last time with the ajax table error and query.ToList exception in Repository.cs
Completed Part 3 of the Assignment as needed.....
Commiting everything till now....Ending at 01:36pm

---------------------------------------------------------------------------------------------------------------------------
2022-12-04, 12:05pm

Trying to solve the sql ecxception error....crsschecked the files but dont see any differences with the files provided by the professor....
Now changing all the files of Product according to sir....
Deleting the old migration and adding another migration......
Manually added the images folder for products reference to the MitalisBookStore.csproj
Run the applicattion to check everything working properly........ can edit and delete data....

01:22pm
Starting to add stored procedure for product....
Updated method of SP_Call.cs as per sir.....and implemented in SD.cs in the MitalisBooks.Utility project.....
Added migration called AddStoredProc and copied code as per sir to implement.....

Starting with Displaying Products on Home Page....
Updating home controller with using UnitOfWork.....
Edited the Index method for returning the list of products from UnitOfWork......
Modifying the Index.cshtml page to display all the products....
Edited the _Layout.cshtml to take the index of Home Page in "MitalisBookStore"
It showed the same pages in Home as well as MitalisBookStore ....hence created a new view called HomePage and added the view in HomeController.cs
Everything works good....still having the datatable alert popup....
Commiting for now....taking a break at 04:25pm

---------------------------------------------------------------------------------------------------------------------------
2022-12-08, 06:20pm

Part 5 of the Assignment
Checking whether everything is perfect....
Pages run properly as expected...doing minor changes with the display of the view pages...
Added some books to the project and did some styling in the Home Page to display the products attractively...
Commiting all the changes to github.....Done with the assignment
Will publish the application to Microsoft Azure Now...