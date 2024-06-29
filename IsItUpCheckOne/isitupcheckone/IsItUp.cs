using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

using isitupcheckone.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

using Newtonsoft.Json;

using static System.String;

namespace isitupcheckone;

public class IsItUp
{
    private string serverOne;
    private string serverTwo;
    private string serverThree;
    private string serverFour;
    private string serverFive;
    private string serverSix;
    private string serverSeven;
    private string serverEight;
    private string serverNine;
    private string serverTen;
    private string serverEleven;
    private string serverTwelve;
    private string serverThirteen;
    private string serverFourteen;
    private string serverFifteen;
    private string serverSixteen;
    private string serverSeventeen;
    private string serverEighteen;
    private string serverNineteen;
    private string serverTwenty;
    private string serverTwentyOne;
    private string serverTwentyTwo;
    private string serverTwentyThree;
    private string serverTwentyFour;
    private string serverTwentyFive;

    private readonly List<string> serverList = new();
    private List<QueryServers> tempList = new();
    private readonly JsonSerializer _serializer = new();

    private List<QueryResponse> responseList = new();

    private HttpClient _httpClient;
    private HttpClientHandler _handler;

    private static string _expiryDate;

    [FunctionName("IsItUp")]
    public async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequestMessage req,
        ILogger log, CancellationToken cancellationToken)
    {
        log.LogInformation("IsItUpCheckOne function processed a request from CNC.");

        if (req.Content != null)
        {
            var stream = req.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
            using var reader = new StreamReader(await stream);
            using var jsonReader = new JsonTextReader(reader);

            try
            {
                tempList = _serializer.Deserialize<List<QueryServers>>(jsonReader);
            }
            catch (Exception e)
            {
                log.LogInformation("Exception " + e.Message + " " + e.Data);
            }

            log.LogInformation("Made it past Deserialization!");
        }
        else
        {
            log.LogInformation("Request content was NULL!");
        }

        if (tempList is { Count: > 0 })
        {
            foreach (var server in tempList)
            {
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverOne)) { serverList.Add(server.Server); serverOne = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverTwo)) { serverList.Add(server.Server); serverTwo = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverThree)) { serverList.Add(server.Server); serverThree = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverFour)) { serverList.Add(server.Server); serverFour = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverFive)) { serverList.Add(server.Server); serverFive = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverSix)) { serverList.Add(server.Server); serverSix = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverSeven)) { serverList.Add(server.Server); serverSeven = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverEight)) { serverList.Add(server.Server); serverEight = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverNine)) { serverList.Add(server.Server); serverNine = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverTen)) { serverList.Add(server.Server); serverTen = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverEleven)) { serverList.Add(server.Server); serverEleven = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverTwelve)) { serverList.Add(server.Server); serverTwelve = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverThirteen)) { serverList.Add(server.Server); serverThirteen = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverFourteen)) { serverList.Add(server.Server); serverFourteen = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverFifteen)) { serverList.Add(server.Server); serverFifteen = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverSixteen)) { serverList.Add(server.Server); serverSixteen = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverSeventeen)) { serverList.Add(server.Server); serverSeventeen = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverEighteen)) { serverList.Add(server.Server); serverEighteen = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverNineteen)) { serverList.Add(server.Server); serverNineteen = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverTwenty)) { serverList.Add(server.Server); serverTwenty = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverTwentyOne)) { serverList.Add(server.Server); serverTwentyOne = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverTwentyTwo)) { serverList.Add(server.Server); serverTwentyTwo = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverTwentyThree)) { serverList.Add(server.Server); serverTwentyThree = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverTwentyFour)) { serverList.Add(server.Server); serverTwentyFour = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverTwentyFive)) { serverList.Add(server.Server); serverTwentyFive = server.Server; continue; }
            }
        }

        try
        {
            responseList = await GetServers(serverList, log, cancellationToken).ConfigureAwait(false);
        }
        catch (InvalidOperationException e)
        {
            log.LogInformation("Error with HTTP query for server responses " + e.Message + " " + e.Data + " " +
                               e.InnerException);
        }
        catch (ArgumentException e)
        {
            log.LogInformation("Error with HTTP query for server responses " + e.Message + " " + e.Data + " " +
                               e.InnerException);
        }
        catch (HttpRequestException e)
        {
            log.LogInformation("Error with HTTP query for server responses " + e.Message + " " + e.Data + " " +
                               e.InnerException);
        }
        catch (TaskCanceledException e)
        {
            log.LogInformation("Error with HTTP query for server responses " + e.Message + " " + e.Data + " " +
                               e.InnerException);
        }
        catch (NullReferenceException e)
        {
            log.LogInformation("Error with HTTP query for server responses " + e.Message + " " + e.Data + " " + e.InnerException);
        }
        catch (Exception e)
        {
            log.LogInformation("Error with HTTP query for server responses " + e.Message + " " + e.Data);
        }

        return new JsonResult(responseList);
    }

    private async Task<List<QueryResponse>> GetServers(IEnumerable<string> list, ILogger log, CancellationToken cancellationToken)
    {
        log.LogInformation("Querying Servers!");
        var StatusCode = 0;
        long totalTime = 0;
        var note = Empty;
        _expiryDate = Empty;
        
        var timer = new Stopwatch();

        foreach (var server in list)
        {
            if (IsNullOrEmpty(server)) continue;

            _handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = ServerCertificateCustomValidation
            };

            _httpClient = new HttpClient(_handler)
            {
                Timeout = TimeSpan.FromSeconds(20)
            };
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
            _httpClient.DefaultRequestHeaders.Add("Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.7");
            _httpClient.DefaultRequestHeaders.Add("Accept", "text/html,application/xml,application/json");
            _httpClient.DefaultRequestHeaders.Add("Accept-Language", "en-us,en;q=0.5");
            _httpClient.DefaultRequestHeaders.Add("Accept-Encoding", "gzip,deflate");

            try
            {
                totalTime = 0;
                StatusCode = 0;
                _expiryDate = Empty;
                note = Empty;
                timer.Start();

                try
                {
                    var result = await _httpClient.GetAsync(server, cancellationToken);

                    if (result != null)
                    {
                        StatusCode = (int)result.StatusCode;

                        if (StatusCode is > 299 or 0)
                        {
                            if (StatusCode == 0)
                            {
                                note = "Server Returned Status Code " + result.StatusCode + "which means there is an issue with it but did not return an error status code to present.";
                            }
                            else
                            {
                                note = "Server Returned: " + result.StatusCode;
                            }
                        }
                    }
                    else
                    {
                        note = "Server Returned: No result or exception, which means there is an issue with it but did not return an error status code to present you. You should investigate this as soon as possible to see what the issue is and take any corrective actions.";
                    }
                }
                catch (HttpRequestException e)
                {
                    log.LogInformation("Error in HTTP Request with the following information " + e.Message + " " + e.Data +
                                       " " + e.StatusCode + " " + e.InnerException?.Message + " " + e.InnerException?.InnerException?.Message);

                    if (e.StatusCode != null)
                    {
                        StatusCode = (int)e.StatusCode;
                    }

                    if (e.Message != null || e.InnerException != null)
                    {
                        note = "Server returned the following error " + e.Message + " " + e.InnerException?.Message + " " + e.InnerException?.InnerException?.Message;
                    }
                }
                catch (TaskCanceledException e)
                {
                    log.LogInformation("Timeout with HTTP Request " + e.Message + " " + e.Data + " " + e.InnerException?.Message + " " + e.InnerException?.InnerException?.Message);

                    if (e.Message != null || e.InnerException != null) {
                        note = "Server returned the following error " + e.Message + " " + e.InnerException?.Message + " " + e.InnerException?.InnerException?.Message;
                    }
                }
                catch (Exception e)
                {
                    log.LogInformation("Caught Inner Try with " + e.Message + " " + e.Data + " " + e.InnerException?.Message + " " + e.InnerException?.InnerException?.Message);

                    if (e.Message != null || e.InnerException != null) {
                        note = "Server returned the following error " + e.Message + " " + e.InnerException?.Message + " " + e.InnerException?.InnerException?.Message;
                    }
                }

                timer.Stop();
                totalTime = timer.ElapsedMilliseconds;
                timer.Reset();
            }
            catch (Exception e)
            {
                log.LogInformation("General Error " + e.Message + " " + e.Data + " " + e.InnerException?.Message + " " + e.InnerException?.InnerException?.Message);
            }
            finally
            {
                if (timer.IsRunning)
                {
                    timer.Stop();
                    totalTime = timer.ElapsedMilliseconds;
                    timer.Reset();
                }

                if (!IsNullOrEmpty(server))
                {
                    var item = new QueryResponse()
                    {
                        responseServer = server,
                        responseServerResponse = StatusCode,
                        responseServerTime = totalTime,
                        responseServerCert = !IsNullOrEmpty(_expiryDate) ? _expiryDate : "Unknown",
                        responseServerNote = !IsNullOrEmpty(note) ? note : "No problems reported!",
                    };

                    responseList.Add(item);

                    log.LogInformation("Server: " + server + " Status Code: " + StatusCode + " Time: " + totalTime);
                    log.LogInformation($"CertDate1 was {_expiryDate}");
                }
            }

            _handler.Dispose();
            _httpClient.Dispose();
        }

        log.LogInformation("Returning QueryResponse To Caller.");
        
        return responseList;
    }

    public static bool ServerCertificateCustomValidation(HttpRequestMessage requestMessage, X509Certificate2 certificate, X509Chain chain, SslPolicyErrors sslErrors)
    {
        _expiryDate = Empty;
        
        // It is possible to inspect the certificate provided by the server.
        _expiryDate = !IsNullOrEmpty(certificate.GetExpirationDateString()) ? certificate.GetExpirationDateString() : "Unknown";

        return true;
    }
}
