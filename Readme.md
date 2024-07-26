Follow these steps to clone and run the application:

### 1. Clone the Repository

Open your terminal and run the following command:

git clone https://github.com/jktflm/BackendTask.git

### 2. Navigate to the Project Directory

cd BackendTask\BackendTask

### 3. Run the Application
Use the following command to run the application, specifying the number of requests (-n) and format (-f) as per your requirement:

**Fetch 10 activities and save as JSON:**

dotnet run -- -n 10 -f json

**Fetch 5 activities and save as CSV:**

dotnet run -- -n 5 -f csv

**Fetch 15 activities and print to console:**

dotnet run -- -n 15 -f console

Additional Information
File Outputs
JSON File: Saved as activities.json in the project directory.
CSV File: Saved as activities.csv in the project directory.
API Used
The application uses the Bored API to fetch random activities.
