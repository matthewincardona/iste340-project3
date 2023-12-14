using iSchoolWebApp.Models;
using iSchoolWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace iSchoolWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            //build a model to hold my data
            //go and get the data
            DataRetrieval dataR = new DataRetrieval();
            var loadedAbout = await dataR.GetData("about/");
            //turn the data into JSON
            //cast the JSON into my Model
            var rtnResult = JsonConvert.DeserializeObject<AboutModel>(loadedAbout);
            //add to the aboutmodel the pageTitle
            if (rtnResult != null)
            {
                // Add to the about model the pageTitle
                rtnResult.PageTitle = "iSchoolWebApp";

                // Add more data to my Model
                // End the model to the View
                return View(rtnResult);
            }
            //add more data to my Model
            //end the model to the View
            return View(rtnResult);
        }

        public async Task<IActionResult> Degrees()
        {
            // Build a model to hold my data
            // Go and get the data
            DataRetrieval dataR = new DataRetrieval();
            var loadedDegrees = await dataR.GetData("degrees");

            // Turn the data into JSON
            // Cast the JSON into my Model
            var rtnResult = JsonConvert.DeserializeObject<DegreesModel>(loadedDegrees);

            // Add to the about model the pageTitle
            if (rtnResult != null)
            {
                // Add to the about model the pageTitle
                rtnResult.PageTitle = "iSchoolWebApp";

                // Add more data to my Model
                // End the model to the View
                return View(rtnResult);
            }

            // Add more data to my Model
            // End the model to the View
            return View(rtnResult);
        }
        public async Task<IActionResult> DegreeDetails(string degreeId, string level)
        {
            // Build a model to hold my data
            // Go and get the data for the specific course
            DataRetrieval dataR = new DataRetrieval();
            dynamic loadedDegrees = null;
            if (level == "Undergraduate")
            {
                loadedDegrees = await dataR.GetData($"degrees/undergraduate/degreeName={degreeId}");

            } else
            {
                loadedDegrees = await dataR.GetData($"degrees/graduate/degreeName={degreeId}");
            }

            // Turn the data into JSON
            // Cast the JSON into my Model
            System.Diagnostics.Debug.WriteLine($"Raw JSON Data: {loadedDegrees}");
            var degreeDetails = JsonConvert.DeserializeObject<DegreeDetailsModel>(loadedDegrees);
            System.Diagnostics.Debug.WriteLine($"Deserialized JSON Data: {degreeDetails}");


            // Add more data to my Model
            // End the model to the View
            return View(degreeDetails);
        }
        public async Task<IActionResult> Minors()
        {
            // Build a model to hold my data
            // Go and get the data
            DataRetrieval dataR = new DataRetrieval();
            var loadedMinors = await dataR.GetData("minors/UgMinors");

            // Log or debug the loaded JSON data
            System.Diagnostics.Debug.WriteLine("Loaded JSON data: " + loadedMinors);

            // Turn the data into JSON
            // Cast the JSON into my Model
            var rtnResult = JsonConvert.DeserializeObject<MinorsModel>(loadedMinors);

            // Log or debug the deserialized result
            System.Diagnostics.Debug.WriteLine("Deserialized result: " + JsonConvert.SerializeObject(rtnResult));

            // Add to the about model the pageTitle
            if (rtnResult != null)
            {
                // Add to the about model the pageTitle
                rtnResult.PageTitle = "iSchoolWebApp";

                // Add more data to my Model
                // End the model to the View
                return View(rtnResult);
            }

            // Add more data to my Model
            // End the model to the View
            return View(rtnResult);
        }

        public async Task<IActionResult> People()
        {
            // Build a model to hold my data
            // Go and get the data
            DataRetrieval dataR = new DataRetrieval();
            var loadedPeople = await dataR.GetData("people");

            // Turn the data into JSON
            // Cast the JSON into my Model
            var rtnResult = JsonConvert.DeserializeObject<PeopleModel>(loadedPeople);

            // Add to the about model the pageTitle
            if (rtnResult != null)
            {
                // Add to the about model the pageTitle
                rtnResult.PageTitle = "iSchoolWebApp";

                // Add more data to my Model
                // End the model to the View
                return View(rtnResult);
            }

            // Add more data to my Model
            // End the model to the View
            return View(rtnResult);
        }
        public async Task<IActionResult> Courses()
        {
            // Build a model to hold my data
            // Go and get the data
            DataRetrieval dataR = new DataRetrieval();
            var loadedCourses = await dataR.GetData("courses");

            // Turn the data into JSON
            // Cast the JSON into my Model
            // Deserialize the JSON array into a List<CourseDegree>
            var courseDegreesList = JsonConvert.DeserializeObject<List<CourseDegree>>(loadedCourses);

            var rtnResult = new CoursesModel
            {
                PageTitle = "iSchoolWebApp",
                CourseDegrees = courseDegreesList
            };

            // Return the view with the populated model
            return View(rtnResult);

        }
        public async Task<IActionResult> CourseDetails(string courseId)
        {
            // Build a model to hold my data
            // Go and get the data for the specific course
            DataRetrieval dataR = new DataRetrieval();
            var loadedCourse = await dataR.GetData($"course/courseID={courseId}");

            // Turn the data into JSON
            // Cast the JSON into my Model
            System.Diagnostics.Debug.WriteLine($"Raw JSON Data: {loadedCourse}");
            var courseDetails = JsonConvert.DeserializeObject<CourseDetailsModel>(loadedCourse);
            System.Diagnostics.Debug.WriteLine($"Deserialized JSON Data: {courseDetails}");


            // Add more data to my Model
            // End the model to the View
            return View(courseDetails);
        }
        public async Task<IActionResult> Employment()
        {
            // Build a model to hold my data
            // Go and get the data
            DataRetrieval dataR = new DataRetrieval();
            var loadedEmployment= await dataR.GetData("employment");

            // Turn the data into JSON
            // Cast the JSON into my Model
            System.Diagnostics.Debug.WriteLine($"Raw JSON Data: {loadedEmployment}");
            var rtnResult = JsonConvert.DeserializeObject<EmploymentModel>(loadedEmployment);

            // Add to the about model the pageTitle
            if (rtnResult != null)
            {
                // Add to the about model the pageTitle
                rtnResult.PageTitle = "iSchoolWebApp";

                // Add more data to my Model
                // End the model to the View
                return View(rtnResult);
            }

            // Add more data to my Model
            // End the model to the View
            return View(rtnResult);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}