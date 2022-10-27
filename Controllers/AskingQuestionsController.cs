// Jacob Dekok
// 10/25/2022
// Asking Questions Endpoint
// The user gives two inputs and the 
// program uses those inputs to ask questions
// Peer Reviewed by: Reed Goodwin- Well written code! I like the way it shows the question asked so the user has some idea of what is going on!
// "I wrote the questions in the url bar before I handed the computer to Reed lol My bad ^" - Jacob



using Microsoft.AspNetCore.Mvc;

namespace dekokJAskingQuestionsEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class AskingQuestionsController : ControllerBase
{
    [HttpGet]
    [Route("Asking/{userName}/{userFavFood}")]

    public string AskingQuestions(string userName, string userFavFood)
    {
        return $"What's your name? What is your favorite food?       My name is {userName}, and my favorite food is {userFavFood}.";
    }
}
