namespace YourNamespace.Controllers

open Microsoft.AspNetCore.Mvc

// Define the HomeController in F#
type HomeController() =
    inherit Controller()

    // Action for the Index view
    member this.Index() : IActionResult =
        this.View()

    // Action for the TermsAndConditions view
    member this.TermsAndConditions() : IActionResult =
        this.View()

    // Action for the Registration view
    member this.Registration() : IActionResult =
        this.View()

    // Action for the Dashboard view
    member this.Dashboard() : IActionResult =
        this.View("Dashboard")

    // Action for the Account view
    member this.Account() : IActionResult =
        // Add username to ViewData
        this.ViewData.["Username"] <- "John Doe"  // Replace with actual username logic
        this.View("Account")
