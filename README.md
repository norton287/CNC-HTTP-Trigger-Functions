👋 Greetings! These Azure Functions are the Command and Control functions that communicates with the three other polling functions (Is It Up Check One/Two/Three, see those repose for those specific code items) and processes and returns their JSON data to the mobile after after a successful polling cycle.

1. **Server List:** You provide a list of web servers you want to monitor via the mobile app.
2. **The CNC Purpose:**  This function sends the configured list of URLs to each of the three polling functions and then awaits their JSON replies.
3. **Health Report:** It gathers details like response time, HTTP status code, and certificate expiration in JSON format from the remote functions and then returns that data to be processed by the mobile app on the users phone to be display graphically in tables and charts, etc. in a nice friendly format as to their URL status'. 
4. **Sharing the News:**  The results are compiled into a neat JSON report, and the Command and Control Function collates this information from the 3 remote azure functions and then returns it to the mobile app to be presented to the user or returns a negative response.  Even if a remote polling function doesn't return anything it will insert a default value and return that to alert the app that it did not return any data from that function.

**Why It Matters:**

* **One Point of Control:** The CNC controls and handles the start and collection of information from the three azure polling functions.
* **Lightweight By Design:** Using an HTTP function by design is lightweight and an efficient way to handle the control and data collection.  It only runs when triggered so the polling cycle is managed by the app.
* **Cost Control:**  Control the cost of the function by restricting, in the app, the minimum polling time, but also you can extend the function to allow more error handling and make it more responsive and faster.  This is a proof of concept not a finished product.  Use this as a starting point for your app or as a new way of thinking about how to poll remote devices effeciently.

**App Server List Customization:**
* **`Remote Functions`:** You can extend the code to allow for more than three remote polling functions and also include looping logic as well to be more efficient in handling building the lists and compiling the returned JSON data.
* **Error Handling:**  Customize the exception handling and function logic to be even more robust in handling things like regional azure outages, a hung remote function, etc.
* **JSON Result:** Tailor the format of the JSON returned to add additional polling data because there can be more collected.  Remember this is an HTTP Trigger function and you cannot use ICMP from any Azure product due to DDOS security measures they have implemented so be creative in how you want to poll and retrieve UP/DOWN statistics.
