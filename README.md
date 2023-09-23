# Personal Website
This is a portfolio site/blog that I am building with ASP.NET Razor Pages and Postgres. The prod version of the site is live at __TODO__. 

The backend logic for the blog portion allows me to write posts in Markdown syntax and store them in a Postgres database hosted on a Digital Ocean droplet via coolify. Then within each Razor Page, I render the markdown in HTML via Markdig.

### TODO features:
* Add a frontend that allows me to write, preview, and submit posts without needing to upload them directly to the database.
* Add a contact page 
* Dynamic styling for the nav bar 
* "spotlight" effect wherever the client cursor is using javascript (make the area directly around the cursor a slightly lighter shade of blue)
* Additional scalability and styling for mobile