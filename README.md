# Publish/Subscribe Pattern

This project will demonstrate how this patterns works

## Project Structure

#### 1. Publisher - PubSub.Api.Publisher
* This project will demonstrate on how the publisher works by using ASP.Net Web API
* There's 2 Api, which will handle Subscriber Registration and Sending Message to all Subscribers

#### 2. Subscriber - PubSub.Owin.Subscriber
* This project will demonstrate on how the publisher works 
* During initialization, this project will call Subscriber Registration Api on the Publisher
* Once the project Running, it has an Api to receive message from the publisher

#### 3. Modules
* It's a core functionality of Publisher and Subscriber which contains of Lib/Interface and Implementation project for each module, It's allowing user to extend to different Implementation as per requirement

#### 4. Unit Test
* Contains of Unit Test Cases for it's Modules



## Prerequisites

* Solution was made using Visual Studio 2015, so Visual Studio 2015 or above is required to run it's solution.
* Use PostMan or any other application to trigger Api


## Running the tests


1. Run the Publisher ASP.Net Web API project
2. Once the Publisher loaded, execute Subscriber .exe file (**PubSub.Owin.Subscriber.exe**) inside **PubSub.Owin.Subscriber\bin\Debug** or **PubSub.Owin.Subscriber\bin\Release** depend with configuration
3. Key in Subscriber port which will be used to open Self-Host Api for Message Notification
4. You may run as many Subscriber as needed using different Port No
5. Trigger Message Send Api in the Publisher using Rest Client tool
6. Message will be displayed in all of the Subscriber's Console
 


## Author

* **Susanto Budi Nugroho** - *susanto.b.n@gmail.com*

