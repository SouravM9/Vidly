using System.Buffers.Text;
using System.Reflection;
using System;

namespace Vidly
{
    public class help
    {
        //00:00 Introduction
        //02:48 ASP.NET MVC Architecture
        //05:31 Setting Up the Development Environment
        //07:38 Your First ASP.NET MVC 5 App
        //14:34 MVC in Action
        //21:18 Adding a Theme
        //26:49 Action Results
        //31:47 Action Parameters
        //37:42 Convention-based Routing
        //42:58 Attribute-based Routing
        //46:27 Passing Data to the Views
        //50:30 View Models
        //54:19 Razor Views
        //58:38 Partial Views


        // To apply your own Bootstrap
        // 1. Go to https://bootswatch.com/
        // 2. Download the .css file
        // 3. Rename it to bootstrap-theme.css
        // 4. Then add this CSS to _Layout.cshtml file
        //     <link rel = "stylesheet" href="~/lib/bootstrap/dist/css/bootstrap-journal.css" />
        // 5. go to Bootstrap (https://getbootstrap.com/docs/5.0/getting-started/introduction/) and copy the Bundle
        // 6. Replace this line so that we are now using the latest version of bootstrap
        //   <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>

        /* Working with Data
          1
         *Please do two things first then run enable-migrations:

            Add ApplicationDbContext.cs in your Models folder from mosh asp net mvc 5 project.
            In Nuget package manager console, run command: install-package Entityframework.

        add-migration InitialModel

        update-database

         2
        To add new tables
         - Create models

        To add relation between table
            -check the MembershipType & Customer models (one-to-many)

        3
        Seeding the database
            -add-migration PopulateMembershipType
            
         */
    }
}
