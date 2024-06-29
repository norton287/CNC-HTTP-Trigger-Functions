👋 Greetings! This Azure Function one of three dedicated website monitoring assistants! It's like one of three diligent postmen, checking in on your servers and reporting back on their health. Here's how it works:

1. **Server List:** You provide a list of web servers you want to monitor via the mobile app.
2. **The Checkup:**  This function sends a friendly "ping" to each server, timing how long it takes to get a response.
3. **Health Report:** It gathers details like response time, HTTP status code, and certificate expiration. 
4. **Sharing the News:**  The results are compiled into a neat JSON report, and this is sent to a master Command and Control Function to collate the information from the remote 3 functions and then return it to the mobile app to be presented to the user.

**Why It Matters:**

* **Early Detection:** Catch potential issues like slowdowns or outages before they affect your users.
* **Performance Insights:** Track your servers' responsiveness over time and identify areas for improvement.
* **Peace of Mind:**  Rest assured that your websites are being monitored, giving you one less thing to worry about!

**App Server List Customization:**
* **`serverList`:** Update the server list to be polled within the app, this contains the URLs of your servers.
* **Error Handling:**  Customize the exception handling in the `GetServers` method to suit your logging preferences.
* **JSON Result:** Tailor the format of the JSON report (in `responseList`) if needed.
