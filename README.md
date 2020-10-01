# Take back your time; Let AI do the work for you!

We all have those tasks that keep coming back, taking away from the tasks we really would want to be doing. Maybe it's writing your hours in different systems for your clients, claiming back your expenses, or typing data from a form into that legacy system. We can't change the underlying systems, so we are just stuck with this manual effort time and time again... Or are we?

What if we could automate these tasks, without the need to change our applications? In this session full of demos you will learn how to use UI Flows to set up your personal RPA helpers, that will take these repeating actions out of your hands. And we will make your flows even smarter, by using the power of Microsoft Cognitive Services to recognize text and images. Together these services allow us to automate all those tedious repeating chores, allowing us to focus on our interesting tasks. And all this using an intuitive UI, without the need to write any code.

## Power Virtual Agent

We use a bot built in PVA for our fourth demo, to retrieve signed timesheets from SharePoint, or send them to the customer for signing. After the bot has been deployed and published, we can use the following types of sentences to start the conversation.

- I would like to get a timesheet
- Can you give me my timesheet
- Please get my timesheet for Contoso
- I'm looking for the timesheet of Contoso of January
- Get me my timesheet please
- I would like to get a timesheet for Contoso

## Deployment

### Form Recognizer

Train your model by adding the [training timesheets](assets/training-timesheets) in the [Form OCR Testing Tool](https://fott.azurewebsites.net/projects/YTn93MVlD/predict). Use the following settings while creating the connection.

- SAS URI: Blob SAS token with container name added
  - [https://\<blob-storage-account>.blob.core.windows.net/\<container>?sv=2019-12-12&ss=bfqt&srt=sco&sp=aaaaaa&se=2025-10-01T05:01:01Z&st=2020-09-30T21:01:01Z&spr=https&sig=a%hs1212asSssDFb]()

After creating the connection, create a new project using the following settings.

- Folder path
  - Leave empty
- Form recognizer service URI
  - [https://\<form-recognizer-account>.cognitiveservices.azure.com/]()
- API key
  - aaaaaaaaaa1111111111bbbbbbbb2222

### SharePoint

Create a Timesheets folder below the [Default Documents](https://\<tenant>.sharepoint.com/sites/\<site-name>/Shared%20Documents/) site in SharePoint. This will be used in the various interfaces.

### Power Platform

Create a new Power Platform environment on the [admin center](https://admin.powerplatform.microsoft.com/environments). Once created, import the [full solution](assets/power-platform/take-back-your-time-let-ai-do-the-work-for-you-full.zip) in the solutions tab on the [maker portal](https://make.powerapps.com/).

#### Power Virtual Agent Channels

After creating the bot, go to the channels tab in the [PVA portal](https://powerva.microsoft.com/). Set up the channels which you could like to use later on.

#### Power Automate

Import the flows for [demo 3](assets\power-platform\power-automate-flow-demo-3.zip) and [demo 4](assets\power-platform\power-automate-flow-demo-4.zip) in the [Power Automate portal](https://emea.flow.microsoft.com/).
