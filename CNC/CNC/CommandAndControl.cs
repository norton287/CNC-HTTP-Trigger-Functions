using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using CNC.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

using Newtonsoft.Json;

using static System.String;

namespace CNC;

public class CommandAndControl
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

    private string responseServerOne;
    private string responseServerTwo;
    private string responseServerThree;
    private string responseServerFour;
    private string responseServerFive;
    private string responseServerSix;
    private string responseServerSeven;
    private string responseServerEight;
    private string responseServerNine;
    private string responseServerTen;
    private string responseServerEleven;
    private string responseServerTwelve;
    private string responseServerThirteen;
    private string responseServerFourteen;
    private string responseServerFifteen;
    private string responseServerSixteen;
    private string responseServerSeventeen;
    private string responseServerEighteen;
    private string responseServerNineteen;
    private string responseServerTwenty;
    private string responseServerTwentyOne;
    private string responseServerTwentyTwo;
    private string responseServerTwentyThree;
    private string responseServerTwentyFour;
    private string responseServerTwentyFive;
    private int responseServer1Response1;
    private int responseServer1Response2;
    private int responseServer1Response3;
    private int responseServer2Response1;
    private int responseServer2Response2;
    private int responseServer2Response3;
    private int responseServer3Response1;
    private int responseServer3Response2;
    private int responseServer3Response3;
    private int responseServer4Response1;
    private int responseServer4Response2;
    private int responseServer4Response3;
    private int responseServer5Response1;
    private int responseServer5Response2;
    private int responseServer5Response3;
    private int responseServer6Response1;
    private int responseServer6Response2;
    private int responseServer6Response3;
    private int responseServer7Response1;
    private int responseServer7Response2;
    private int responseServer7Response3;
    private int responseServer8Response1;
    private int responseServer8Response2;
    private int responseServer8Response3;
    private int responseServer9Response1;
    private int responseServer9Response2;
    private int responseServer9Response3;
    private int responseServer10Response1;
    private int responseServer10Response2;
    private int responseServer10Response3;
    private int responseServer11Response1;
    private int responseServer11Response2;
    private int responseServer11Response3;
    private int responseServer12Response1;
    private int responseServer12Response2;
    private int responseServer12Response3;
    private int responseServer13Response1;
    private int responseServer13Response2;
    private int responseServer13Response3;
    private int responseServer14Response1;
    private int responseServer14Response2;
    private int responseServer14Response3;
    private int responseServer15Response1;
    private int responseServer15Response2;
    private int responseServer15Response3;
    private int responseServer16Response1;
    private int responseServer16Response2;
    private int responseServer16Response3;
    private int responseServer17Response1;
    private int responseServer17Response2;
    private int responseServer17Response3;
    private int responseServer18Response1;
    private int responseServer18Response2;
    private int responseServer18Response3;
    private int responseServer19Response1;
    private int responseServer19Response2;
    private int responseServer19Response3;
    private int responseServer20Response1;
    private int responseServer20Response2;
    private int responseServer20Response3;
    private int responseServer21Response1;
    private int responseServer21Response2;
    private int responseServer21Response3;
    private int responseServer22Response1;
    private int responseServer22Response2;
    private int responseServer22Response3;
    private int responseServer23Response1;
    private int responseServer23Response2;
    private int responseServer23Response3;
    private int responseServer24Response1;
    private int responseServer24Response2;
    private int responseServer24Response3;
    private int responseServer25Response1;
    private int responseServer25Response2;
    private int responseServer25Response3;
    private string responseServer1Cert1;
    private string responseServer1Cert2;
    private string responseServer1Cert3;
    private string responseServer2Cert1;
    private string responseServer2Cert2;
    private string responseServer2Cert3;
    private string responseServer3Cert1;
    private string responseServer3Cert2;
    private string responseServer3Cert3;
    private string responseServer4Cert1;
    private string responseServer4Cert2;
    private string responseServer4Cert3;
    private string responseServer5Cert1;
    private string responseServer5Cert2;
    private string responseServer5Cert3;
    private string responseServer6Cert1;
    private string responseServer6Cert2;
    private string responseServer6Cert3;
    private string responseServer7Cert1;
    private string responseServer7Cert2;
    private string responseServer7Cert3;
    private string responseServer8Cert1;
    private string responseServer8Cert2;
    private string responseServer8Cert3;
    private string responseServer9Cert1;
    private string responseServer9Cert2;
    private string responseServer9Cert3;
    private string responseServer10Cert1;
    private string responseServer10Cert2;
    private string responseServer10Cert3;
    private string responseServer11Cert1;
    private string responseServer11Cert2;
    private string responseServer11Cert3;
    private string responseServer12Cert1;
    private string responseServer12Cert2;
    private string responseServer12Cert3;
    private string responseServer13Cert1;
    private string responseServer13Cert2;
    private string responseServer13Cert3;
    private string responseServer14Cert1;
    private string responseServer14Cert2;
    private string responseServer14Cert3;
    private string responseServer15Cert1;
    private string responseServer15Cert2;
    private string responseServer15Cert3;
    private string responseServer16Cert1;
    private string responseServer16Cert2;
    private string responseServer16Cert3;
    private string responseServer17Cert1;
    private string responseServer17Cert2;
    private string responseServer17Cert3;
    private string responseServer18Cert1;
    private string responseServer18Cert2;
    private string responseServer18Cert3;
    private string responseServer19Cert1;
    private string responseServer19Cert2;
    private string responseServer19Cert3;
    private string responseServer20Cert1;
    private string responseServer20Cert2;
    private string responseServer20Cert3;
    private string responseServer21Cert1;
    private string responseServer21Cert2;
    private string responseServer21Cert3;
    private string responseServer22Cert1;
    private string responseServer22Cert2;
    private string responseServer22Cert3;
    private string responseServer23Cert1;
    private string responseServer23Cert2;
    private string responseServer23Cert3;
    private string responseServer24Cert1;
    private string responseServer24Cert2;
    private string responseServer24Cert3;
    private string responseServer25Cert1;
    private string responseServer25Cert2;
    private string responseServer25Cert3;
    private long responseServer1Time1;
    private long responseServer1Time2;
    private long responseServer1Time3;
    private long responseServer2Time1;
    private long responseServer2Time2;
    private long responseServer2Time3;
    private long responseServer3Time1;
    private long responseServer3Time2;
    private long responseServer3Time3;
    private long responseServer4Time1;
    private long responseServer4Time2;
    private long responseServer4Time3;
    private long responseServer5Time1;
    private long responseServer5Time2;
    private long responseServer5Time3;
    private long responseServer6Time1;
    private long responseServer6Time2;
    private long responseServer6Time3;
    private long responseServer7Time1;
    private long responseServer7Time2;
    private long responseServer7Time3;
    private long responseServer8Time1;
    private long responseServer8Time2;
    private long responseServer8Time3;
    private long responseServer9Time1;
    private long responseServer9Time2;
    private long responseServer9Time3;
    private long responseServer10Time1;
    private long responseServer10Time2;
    private long responseServer10Time3;
    private long responseServer11Time1;
    private long responseServer11Time2;
    private long responseServer11Time3;
    private long responseServer12Time1;
    private long responseServer12Time2;
    private long responseServer12Time3;
    private long responseServer13Time1;
    private long responseServer13Time2;
    private long responseServer13Time3;
    private long responseServer14Time1;
    private long responseServer14Time2;
    private long responseServer14Time3;
    private long responseServer15Time1;
    private long responseServer15Time2;
    private long responseServer15Time3;
    private long responseServer16Time1;
    private long responseServer16Time2;
    private long responseServer16Time3;
    private long responseServer17Time1;
    private long responseServer17Time2;
    private long responseServer17Time3;
    private long responseServer18Time1;
    private long responseServer18Time2;
    private long responseServer18Time3;
    private long responseServer19Time1;
    private long responseServer19Time2;
    private long responseServer19Time3;
    private long responseServer20Time1;
    private long responseServer20Time2;
    private long responseServer20Time3;
    private long responseServer21Time1;
    private long responseServer21Time2;
    private long responseServer21Time3;
    private long responseServer22Time1;
    private long responseServer22Time2;
    private long responseServer22Time3;
    private long responseServer23Time1;
    private long responseServer23Time2;
    private long responseServer23Time3;
    private long responseServer24Time1;
    private long responseServer24Time2;
    private long responseServer24Time3;
    private long responseServer25Time1;
    private long responseServer25Time2;
    private long responseServer25Time3;
    private string responseServer1Note1;
    private string responseServer1Note2;
    private string responseServer1Note3;
    private string responseServer2Note1;
    private string responseServer2Note2;
    private string responseServer2Note3;
    private string responseServer3Note1;
    private string responseServer3Note2;
    private string responseServer3Note3;
    private string responseServer4Note1;
    private string responseServer4Note2;
    private string responseServer4Note3;
    private string responseServer5Note1;
    private string responseServer5Note2;
    private string responseServer5Note3;
    private string responseServer6Note1;
    private string responseServer6Note2;
    private string responseServer6Note3;
    private string responseServer7Note1;
    private string responseServer7Note2;
    private string responseServer7Note3;
    private string responseServer8Note1;
    private string responseServer8Note2;
    private string responseServer8Note3;
    private string responseServer9Note1;
    private string responseServer9Note2;
    private string responseServer9Note3;
    private string responseServer10Note1;
    private string responseServer10Note2;
    private string responseServer10Note3;
    private string responseServer11Note1;
    private string responseServer11Note2;
    private string responseServer11Note3;
    private string responseServer12Note1;
    private string responseServer12Note2;
    private string responseServer12Note3;
    private string responseServer13Note1;
    private string responseServer13Note2;
    private string responseServer13Note3;
    private string responseServer14Note1;
    private string responseServer14Note2;
    private string responseServer14Note3;
    private string responseServer15Note1;
    private string responseServer15Note2;
    private string responseServer15Note3;
    private string responseServer16Note1;
    private string responseServer16Note2;
    private string responseServer16Note3;
    private string responseServer17Note1;
    private string responseServer17Note2;
    private string responseServer17Note3;
    private string responseServer18Note1;
    private string responseServer18Note2;
    private string responseServer18Note3;
    private string responseServer19Note1;
    private string responseServer19Note2;
    private string responseServer19Note3;
    private string responseServer20Note1;
    private string responseServer20Note2;
    private string responseServer20Note3;
    private string responseServer21Note1;
    private string responseServer21Note2;
    private string responseServer21Note3;
    private string responseServer22Note1;
    private string responseServer22Note2;
    private string responseServer22Note3;
    private string responseServer23Note1;
    private string responseServer23Note2;
    private string responseServer23Note3;
    private string responseServer24Note1;
    private string responseServer24Note2;
    private string responseServer24Note3;
    private string responseServer25Note1;
    private string responseServer25Note2;
    private string responseServer25Note3;
    
    private List<QueryServers> query1;
    private List<QueryServers> query2;
    private List<QueryServers> query3;

    private List<QueryResponse> response1 = new();
    private List<QueryResponse> response2 = new();
    private List<QueryResponse> response3 = new();

    private List<QueryResponse> masterResponse = new();

    private readonly IConfiguration _configuration;

    private readonly HttpClient _httpClient;

    private string IpAddress;

    private CloudStorageAccount _storageAccount;
    private CloudTableClient _tableClient;
    private CloudTable _table;
    private string _connectionString;

    private readonly JsonSerializer _serializer;
    private Uri BaseUrl;

    public CommandAndControl(IHttpClientFactory httpClientFactory, IConfiguration configuration)
    {
        _configuration = configuration;

        _httpClient = httpClientFactory.CreateClient();

        _serializer = new JsonSerializer();
    }


    [FunctionName("CommandAndControl")]
    public async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]
        HttpRequestMessage req,
        ILogger log, CancellationToken cancellationToken)
    {
        log.LogInformation("CNC processed a request.");

        List<QueryServers> servers = null;
        _httpClient.Timeout = TimeSpan.FromSeconds(900);

        var keyOne = _configuration["Func_One"];
        var keyTwo = _configuration["Func_Two"];
        var keyThree = _configuration["Func_Three"];
        var slotOne = _configuration["Func_One_Slot2"];
        var slotTwo = _configuration["Func_Two_Slot2"];
        var slotThree = _configuration["Func_Three_Slot2"];

        _connectionString = _configuration["AzureWebJobsStorage"];

        try
        {
            var stream = req.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
            using var reader = new StreamReader(await stream);
            using var jsonReader = new JsonTextReader(reader);

            try
            {
                servers = _serializer.Deserialize<List<QueryServers>>(jsonReader);
            }
            catch (Exception e)
            {
                log.LogInformation("Exception " + e.Message + " " + e.Data);
            }

            log.LogInformation("Made it past Deserialization!");
        }
        catch (Exception e)
        {
            log.LogInformation("Error in Query Sent To Server! " + e.Message + " " + e.Data);
            return new OkResult();
        }

        if (servers is { Count: > 0 })
        {
            foreach (var server in servers)
            {
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverOne)) { serverOne = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverTwo)) { serverTwo = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverThree)) { serverThree = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverFour)) { serverFour = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverFive)) { serverFive = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverSix)) { serverSix = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverSeven)) { serverSeven = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverEight)) { serverEight = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverNine)) { serverNine = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverTen)) { serverTen = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverEleven)) { serverEleven = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverTwelve)) { serverTwelve = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverThirteen)) { serverThirteen = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverFourteen)) { serverFourteen = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverFifteen)) { serverFifteen = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverSixteen)) { serverSixteen = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverSeventeen)) { serverSeventeen = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverEighteen)) { serverEighteen = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverNineteen)) { serverNineteen = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverTwenty)) { serverTwenty = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverTwentyOne)) { serverTwentyOne = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverTwentyTwo)) { serverTwentyTwo = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverTwentyThree)) { serverTwentyThree = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverTwentyFour)) { serverTwentyFour = server.Server; continue; }
                if (!IsNullOrEmpty(server.Server) && IsNullOrEmpty(serverTwentyFive)) { serverTwentyFive = server.Server; continue; }
            }
        }

        //Getting Users IP Address From Headers
        try
        {
            if (req.Headers.TryGetValues("X-Real-Ip", out var realIp))
            {
                var parts = realIp.FirstOrDefault()?.Split(':');
                IpAddress = parts[0];
                log.LogInformation($"Request came from IP Address {IpAddress} In First Catch");
            }
            else if (req.Headers.TryGetValues("X-Forwarded-For", out var forwardedFor))
            {
                var parts = forwardedFor.FirstOrDefault()?.Split(':');
                IpAddress = parts[0];
                log.LogInformation($"Request came from IP Address {IpAddress} In Second Catch");
            }
            else
            {
                var parts = req.RequestUri?.Host.Split(':');
                IpAddress = parts[0];
                log.LogInformation($"Request came from IP Address {IpAddress} In Final Else");
            }
        }
        catch (Exception e)
        {
            log.LogInformation("Error in getting IP Address! " + e.Message + " " + e.Data);
        }

        if (servers is { Count: > 0 })
        {
            query1 = servers;
            query2 = servers;
            query3 = servers;
        }
        else
        {
            return new OkResult();
        }

        response1 = await DoQuery(query1, funcUrl: new Uri(slotOne), log).WaitAsync(cancellationToken);
        response2 = await DoQuery(query2, funcUrl: new Uri(slotTwo), log).WaitAsync(cancellationToken);
        response3 = await DoQuery(query3, funcUrl: new Uri(slotThree), log).WaitAsync(cancellationToken);

        log.LogInformation("Made It Past Polling!");

        if (response1 is { Count: > 0 })
        {
            foreach (var response in response1)
            {
                if (IsNullOrEmpty(responseServer1Note1) && responseServer1Response1 == 0 &&
                    IsNullOrEmpty(responseServer10Cert1) && responseServer1Time1 == 0)
                {
                    responseServerOne = response.responseServer;
                    responseServer1Response1 = response.responseServerResponse;
                    responseServer1Note1 = response.responseServerNote;
                    responseServer1Time1 = response.responseServerTime;
                    responseServer1Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer2Note1) && responseServer2Response1 == 0 &&
                    IsNullOrEmpty(responseServer2Cert1) && responseServer2Time1 == 0)
                {
                    responseServerTwo = response.responseServer;
                    responseServer2Response1 = response.responseServerResponse;
                    responseServer2Note1 = response.responseServerNote;
                    responseServer2Time1 = response.responseServerTime;
                    responseServer2Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer3Note1) && responseServer3Response1 == 0 &&
                    IsNullOrEmpty(responseServer3Cert1) && responseServer3Time1 == 0)
                {
                    responseServerThree = response.responseServer;
                    responseServer3Response1 = response.responseServerResponse;
                    responseServer3Note1 = response.responseServerNote;
                    responseServer3Time1 = response.responseServerTime;
                    responseServer3Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer4Note1) && responseServer4Response1 == 0 &&
                    IsNullOrEmpty(responseServer4Cert1) && responseServer4Time1 == 0)
                {
                    responseServerFour = response.responseServer;
                    responseServer4Response1 = response.responseServerResponse;
                    responseServer4Note1 = response.responseServerNote;
                    responseServer4Time1 = response.responseServerTime;
                    responseServer4Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer5Note1) && responseServer5Response1 == 0 &&
                    IsNullOrEmpty(responseServer5Cert1) && responseServer5Time1 == 0)
                {
                    responseServerFive = response.responseServer;
                    responseServer5Response1 = response.responseServerResponse;
                    responseServer5Note1 = response.responseServerNote;
                    responseServer5Time1 = response.responseServerTime;
                    responseServer5Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer6Note1) && responseServer6Response1 == 0 &&
                    IsNullOrEmpty(responseServer6Cert1) && responseServer6Time1 == 0)
                {
                    responseServerSix = response.responseServer;
                    responseServer6Response1 = response.responseServerResponse;
                    responseServer6Note1 = response.responseServerNote;
                    responseServer6Time1 = response.responseServerTime;
                    responseServer6Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer7Note1) && responseServer7Response1 == 0 &&
                    IsNullOrEmpty(responseServer7Cert1) && responseServer7Time1 == 0)
                {
                    responseServerSeven = response.responseServer;
                    responseServer7Response1 = response.responseServerResponse;
                    responseServer7Note1 = response.responseServerNote;
                    responseServer7Time1 = response.responseServerTime;
                    responseServer7Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer8Note1) && responseServer8Response1 == 0 &&
                    IsNullOrEmpty(responseServer8Cert1) && responseServer8Time1 == 0)
                {
                    responseServerEight = response.responseServer;
                    responseServer8Response1 = response.responseServerResponse;
                    responseServer8Note1 = response.responseServerNote;
                    responseServer8Time1 = response.responseServerTime;
                    responseServer8Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer9Note1) && responseServer9Response1 == 0 &&
                    IsNullOrEmpty(responseServer9Cert1) && responseServer9Time1 == 0)
                {
                    responseServerNine = response.responseServer;
                    responseServer9Response1 = response.responseServerResponse;
                    responseServer9Note1 = response.responseServerNote;
                    responseServer9Time1 = response.responseServerTime;
                    responseServer9Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer10Note1) && responseServer10Response1 == 0 &&
                    IsNullOrEmpty(responseServer10Cert1) && responseServer10Time1 == 0)
                {
                    responseServerTen = response.responseServer;
                    responseServer10Response1 = response.responseServerResponse;
                    responseServer10Note1 = response.responseServerNote;
                    responseServer10Time1 = response.responseServerTime;
                    responseServer10Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer11Note1) && responseServer11Response1 == 0 &&
                    IsNullOrEmpty(responseServer11Cert1) && responseServer11Time1 == 0)
                {
                    responseServerEleven = response.responseServer;
                    responseServer11Response1 = response.responseServerResponse;
                    responseServer11Note1 = response.responseServerNote;
                    responseServer11Time1 = response.responseServerTime;
                    responseServer11Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer12Note1) && responseServer12Response1 == 0 &&
                    IsNullOrEmpty(responseServer12Cert1) && responseServer12Time1 == 0)
                {
                    responseServerTwelve = response.responseServer;
                    responseServer12Response1 = response.responseServerResponse;
                    responseServer12Note1 = response.responseServerNote;
                    responseServer12Time1 = response.responseServerTime;
                    responseServer12Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer13Note1) && responseServer13Response1 == 0 &&
                    IsNullOrEmpty(responseServer13Cert1) && responseServer13Time1 == 0)
                {
                    responseServerThirteen = response.responseServer;
                    responseServer13Response1 = response.responseServerResponse;
                    responseServer13Note1 = response.responseServerNote;
                    responseServer13Time1 = response.responseServerTime;
                    responseServer13Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer14Note1) && responseServer14Response1 == 0 &&
                    IsNullOrEmpty(responseServer14Cert1) && responseServer14Time1 == 0)
                {
                    responseServerFourteen = response.responseServer;
                    responseServer14Response1 = response.responseServerResponse;
                    responseServer14Note1 = response.responseServerNote;
                    responseServer14Time1 = response.responseServerTime;
                    responseServer14Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer15Note1) && responseServer15Response1 == 0 &&
                    IsNullOrEmpty(responseServer15Cert1) && responseServer15Time1 == 0)
                {
                    responseServerFifteen = response.responseServer;
                    responseServer15Response1 = response.responseServerResponse;
                    responseServer15Note1 = response.responseServerNote;
                    responseServer15Time1 = response.responseServerTime;
                    responseServer15Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer16Note1) && responseServer16Response1 == 0 &&
                    IsNullOrEmpty(responseServer16Cert1) && responseServer16Time1 == 0)
                {
                    responseServerSixteen = response.responseServer;
                    responseServer16Response1 = response.responseServerResponse;
                    responseServer16Note1 = response.responseServerNote;
                    responseServer16Time1 = response.responseServerTime;
                    responseServer16Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer17Note1) && responseServer17Response1 == 0 &&
                    IsNullOrEmpty(responseServer17Cert1) && responseServer17Time1 == 0)
                {
                    responseServerSeventeen = response.responseServer;
                    responseServer17Response1 = response.responseServerResponse;
                    responseServer17Note1 = response.responseServerNote;
                    responseServer17Time1 = response.responseServerTime;
                    responseServer17Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer18Note1) && responseServer18Response1 == 0 &&
                    IsNullOrEmpty(responseServer18Cert1) && responseServer18Time1 == 0)
                {
                    responseServerEighteen = response.responseServer;
                    responseServer18Response1 = response.responseServerResponse;
                    responseServer18Note1 = response.responseServerNote;
                    responseServer18Time1 = response.responseServerTime;
                    responseServer18Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer19Note1) && responseServer19Response1 == 0 &&
                    IsNullOrEmpty(responseServer19Cert1) && responseServer19Time1 == 0)
                {
                    responseServerNineteen = response.responseServer;
                    responseServer19Response1 = response.responseServerResponse;
                    responseServer19Note1 = response.responseServerNote;
                    responseServer19Time1 = response.responseServerTime;
                    responseServer19Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer20Note1) && responseServer20Response1 == 0 &&
                    IsNullOrEmpty(responseServer20Cert1) && responseServer20Time1 == 0)
                {
                    responseServerTwenty = response.responseServer;
                    responseServer20Response1 = response.responseServerResponse;
                    responseServer20Note1 = response.responseServerNote;
                    responseServer20Time1 = response.responseServerTime;
                    responseServer20Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer21Note1) && responseServer21Response1 == 0 &&
                    IsNullOrEmpty(responseServer21Cert1) && responseServer21Time1 == 0)
                {
                    responseServerTwentyOne = response.responseServer;
                    responseServer21Response1 = response.responseServerResponse;
                    responseServer21Note1 = response.responseServerNote;
                    responseServer21Time1 = response.responseServerTime;
                    responseServer21Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer22Note1) && responseServer22Response1 == 0 &&
                    IsNullOrEmpty(responseServer22Cert1) && responseServer22Time1 == 0)
                {
                    responseServerTwentyTwo = response.responseServer;
                    responseServer22Response1 = response.responseServerResponse;
                    responseServer22Note1 = response.responseServerNote;
                    responseServer22Time1 = response.responseServerTime;
                    responseServer22Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer23Note1) && responseServer23Response1 == 0 &&
                    IsNullOrEmpty(responseServer23Cert1) && responseServer23Time1 == 0)
                {
                    responseServerTwentyThree = response.responseServer;
                    responseServer23Response1 = response.responseServerResponse;
                    responseServer23Note1 = response.responseServerNote;
                    responseServer23Time1 = response.responseServerTime;
                    responseServer23Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer24Note1) && responseServer24Response1 == 0 &&
                    IsNullOrEmpty(responseServer24Cert1) && responseServer24Time1 == 0)
                {
                    responseServerTwentyFour = response.responseServer;
                    responseServer24Response1 = response.responseServerResponse;
                    responseServer24Note1 = response.responseServerNote;
                    responseServer24Time1 = response.responseServerTime;
                    responseServer24Cert1 = response.responseServerCert;
                    continue;
                }

                if (IsNullOrEmpty(responseServer25Note1) && responseServer25Response1 == 0 &&
                    IsNullOrEmpty(responseServer25Cert1) && responseServer25Time1 == 0)
                {
                    responseServerTwentyFive = response.responseServer;
                    responseServer25Response1 = response.responseServerResponse;
                    responseServer25Note1 = response.responseServerNote;
                    responseServer25Time1 = response.responseServerTime;
                    responseServer25Cert1 = response.responseServerCert;
                    continue;
                }
            }
        }

        if (response2 is { Count: > 0 })
        {
            foreach (var response in response2)
            {
                if (IsNullOrEmpty(responseServer1Note2) && responseServer1Response2 == 0 &&
                    IsNullOrEmpty(responseServer1Cert2) && responseServer1Time2 == 0)
                {
                    responseServer1Response2 = response.responseServerResponse2;
                    responseServer1Note2 = response.responseServerNote2;
                    responseServer1Time2 = response.responseServerTime2;
                    responseServer1Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer2Note2) && responseServer2Response2 == 0 &&
                    IsNullOrEmpty(responseServer2Cert2) && responseServer2Time2 == 0)
                {
                    responseServer2Response2 = response.responseServerResponse2;
                    responseServer2Note2 = response.responseServerNote2;
                    responseServer2Time2 = response.responseServerTime2;
                    responseServer2Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer3Note2) && responseServer3Response2 == 0 &&
                    IsNullOrEmpty(responseServer3Cert2) && responseServer3Time2 == 0)
                {
                    responseServer3Response2 = response.responseServerResponse2;
                    responseServer3Note2 = response.responseServerNote2;
                    responseServer3Time2 = response.responseServerTime2;
                    responseServer3Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer4Note2) && responseServer4Response2 == 0 &&
                    IsNullOrEmpty(responseServer4Cert2) && responseServer4Time2 == 0)
                {
                    responseServer4Response2 = response.responseServerResponse2;
                    responseServer4Note2 = response.responseServerNote2;
                    responseServer4Time2 = response.responseServerTime2;
                    responseServer4Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer5Note2) && responseServer5Response2 == 0 &&
                    IsNullOrEmpty(responseServer5Cert2) && responseServer5Time2 == 0)
                {
                    responseServer5Response2 = response.responseServerResponse2;
                    responseServer5Note2 = response.responseServerNote2;
                    responseServer5Time2 = response.responseServerTime2;
                    responseServer5Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer6Note2) && responseServer6Response2 == 0 &&
                    IsNullOrEmpty(responseServer6Cert2) && responseServer6Time2 == 0)
                {
                    responseServer6Response2 = response.responseServerResponse2;
                    responseServer6Note2 = response.responseServerNote2;
                    responseServer6Time2 = response.responseServerTime2;
                    responseServer6Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer7Note2) && responseServer7Response2 == 0 &&
                    IsNullOrEmpty(responseServer7Cert2) && responseServer7Time2 == 0)
                {
                    responseServer7Response2 = response.responseServerResponse2;
                    responseServer7Note2 = response.responseServerNote2;
                    responseServer7Time2 = response.responseServerTime2;
                    responseServer7Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer8Note2) && responseServer8Response2 == 0 &&
                    IsNullOrEmpty(responseServer8Cert2) && responseServer8Time2 == 0)
                {
                    responseServer8Response2 = response.responseServerResponse2;
                    responseServer8Note2 = response.responseServerNote2;
                    responseServer8Time2 = response.responseServerTime2;
                    responseServer8Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer9Note2) && responseServer9Response2 == 0 &&
                    IsNullOrEmpty(responseServer9Cert2) && responseServer9Time2 == 0)
                {
                    responseServer9Response2 = response.responseServerResponse2;
                    responseServer9Note2 = response.responseServerNote2;
                    responseServer9Time2 = response.responseServerTime2;
                    responseServer9Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer10Note2) && responseServer10Response2 == 0 &&
                    IsNullOrEmpty(responseServer10Cert2) && responseServer10Time2 == 0)
                {
                    responseServer10Response2 = response.responseServerResponse2;
                    responseServer10Note2 = response.responseServerNote2;
                    responseServer10Time2 = response.responseServerTime2;
                    responseServer10Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer11Note2) && responseServer11Response2 == 0 &&
                    IsNullOrEmpty(responseServer11Cert2) && responseServer11Time2 == 0)
                {
                    responseServer11Response2 = response.responseServerResponse2;
                    responseServer11Note2 = response.responseServerNote2;
                    responseServer11Time2 = response.responseServerTime2;
                    responseServer11Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer12Note2) && responseServer12Response2 == 0 &&
                    IsNullOrEmpty(responseServer12Cert2) && responseServer12Time2 == 0)
                {
                    responseServer12Response2 = response.responseServerResponse2;
                    responseServer12Note2 = response.responseServerNote2;
                    responseServer12Time2 = response.responseServerTime2;
                    responseServer12Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer13Note2) && responseServer13Response2 == 0 &&
                    IsNullOrEmpty(responseServer13Cert2) && responseServer13Time2 == 0)
                {
                    responseServer13Response2 = response.responseServerResponse2;
                    responseServer13Note2 = response.responseServerNote2;
                    responseServer13Time2 = response.responseServerTime2;
                    responseServer13Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer14Note2) && responseServer14Response2 == 0 &&
                    IsNullOrEmpty(responseServer14Cert2) && responseServer14Time2 == 0)
                {
                    responseServer14Response2 = response.responseServerResponse2;
                    responseServer14Note2 = response.responseServerNote2;
                    responseServer14Time2 = response.responseServerTime2;
                    responseServer14Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer15Note2) && responseServer15Response2 == 0 &&
                    IsNullOrEmpty(responseServer15Cert2) && responseServer15Time2 == 0)
                {
                    responseServer15Response2 = response.responseServerResponse2;
                    responseServer15Note2 = response.responseServerNote2;
                    responseServer15Time2 = response.responseServerTime2;
                    responseServer15Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer16Note2) && responseServer16Response2 == 0 &&
                    IsNullOrEmpty(responseServer16Cert2) && responseServer16Time2 == 0)
                {
                    responseServer16Response2 = response.responseServerResponse2;
                    responseServer16Note2 = response.responseServerNote2;
                    responseServer16Time2 = response.responseServerTime2;
                    responseServer16Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer17Note2) && responseServer17Response2 == 0 &&
                    IsNullOrEmpty(responseServer17Cert2) && responseServer17Time2 == 0)
                {
                    responseServer17Response2 = response.responseServerResponse2;
                    responseServer17Note2 = response.responseServerNote2;
                    responseServer17Time2 = response.responseServerTime2;
                    responseServer17Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer18Note2) && responseServer18Response2 == 0 &&
                    IsNullOrEmpty(responseServer18Cert2) && responseServer18Time2 == 0)
                {
                    responseServer18Response2 = response.responseServerResponse2;
                    responseServer18Note2 = response.responseServerNote2;
                    responseServer18Time2 = response.responseServerTime2;
                    responseServer18Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer19Note2) && responseServer19Response2 == 0 &&
                    IsNullOrEmpty(responseServer19Cert2) && responseServer19Time2 == 0)
                {
                    responseServer19Response2 = response.responseServerResponse2;
                    responseServer19Note2 = response.responseServerNote2;
                    responseServer19Time2 = response.responseServerTime2;
                    responseServer19Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer20Note2) && responseServer20Response2 == 0 &&
                    IsNullOrEmpty(responseServer20Cert2) && responseServer20Time2 == 0)
                {
                    responseServer20Response2 = response.responseServerResponse2;
                    responseServer20Note2 = response.responseServerNote2;
                    responseServer20Time2 = response.responseServerTime2;
                    responseServer20Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer21Note2) && responseServer21Response2 == 0 &&
                    IsNullOrEmpty(responseServer21Cert2) && responseServer21Time2 == 0)
                {
                    responseServer21Response2 = response.responseServerResponse2;
                    responseServer21Note2 = response.responseServerNote2;
                    responseServer21Time2 = response.responseServerTime2;
                    responseServer21Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer22Note2) && responseServer22Response2 == 0 &&
                    IsNullOrEmpty(responseServer22Cert2) && responseServer22Time2 == 0)
                {
                    responseServer22Response2 = response.responseServerResponse2;
                    responseServer22Note2 = response.responseServerNote2;
                    responseServer22Time2 = response.responseServerTime2;
                    responseServer22Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer23Note2) && responseServer23Response2 == 0 &&
                    IsNullOrEmpty(responseServer23Cert2) && responseServer23Time2 == 0)
                {
                    responseServer23Response2 = response.responseServerResponse2;
                    responseServer23Note2 = response.responseServerNote2;
                    responseServer23Time2 = response.responseServerTime2;
                    responseServer23Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer24Note2) && responseServer24Response2 == 0 &&
                    IsNullOrEmpty(responseServer24Cert2) && responseServer24Time2 == 0)
                {
                    responseServer24Response2 = response.responseServerResponse2;
                    responseServer24Note2 = response.responseServerNote2;
                    responseServer24Time2 = response.responseServerTime2;
                    responseServer24Cert2 = response.responseServerCert2;
                    continue;
                }

                if (IsNullOrEmpty(responseServer25Note2) && responseServer25Response2 == 0 &&
                    IsNullOrEmpty(responseServer25Cert2) && responseServer25Time2 == 0)
                {
                    responseServer25Response2 = response.responseServerResponse2;
                    responseServer25Note2 = response.responseServerNote2;
                    responseServer25Time2 = response.responseServerTime2;
                    responseServer25Cert2 = response.responseServerCert2;
                    continue;
                }
            }
        }

        if (response3 is { Count: > 0 })
        {
            foreach (var response in response3)
            {
                if (IsNullOrEmpty(responseServer1Note3) && responseServer1Response3 == 0 &&
                    IsNullOrEmpty(responseServer1Cert3) && responseServer1Time3 == 0)
                {
                    responseServer1Response3 = response.responseServerResponse3;
                    responseServer1Note3 = response.responseServerNote3;
                    responseServer1Time3 = response.responseServerTime3;
                    responseServer1Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer2Note3) && responseServer2Response3 == 0 &&
                    IsNullOrEmpty(responseServer2Cert3) && responseServer2Time3 == 0)
                {
                    responseServer2Response3 = response.responseServerResponse3;
                    responseServer2Note3 = response.responseServerNote3;
                    responseServer2Time3 = response.responseServerTime3;
                    responseServer2Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer3Note3) && responseServer3Response3 == 0 &&
                    IsNullOrEmpty(responseServer3Cert3) && responseServer3Time3 == 0)
                {
                    responseServer3Response3 = response.responseServerResponse3;
                    responseServer3Note3 = response.responseServerNote3;
                    responseServer3Time3 = response.responseServerTime3;
                    responseServer3Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer4Note3) && responseServer4Response3 == 0 &&
                    IsNullOrEmpty(responseServer4Cert3) && responseServer4Time3 == 0)
                {
                    responseServer4Response3 = response.responseServerResponse3;
                    responseServer4Note3 = response.responseServerNote3;
                    responseServer4Time3 = response.responseServerTime3;
                    responseServer4Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer5Note3) && responseServer5Response3 == 0 &&
                    IsNullOrEmpty(responseServer5Cert3) && responseServer5Time3 == 0)
                {
                    responseServer5Response3 = response.responseServerResponse3;
                    responseServer5Note3 = response.responseServerNote3;
                    responseServer5Time3 = response.responseServerTime3;
                    responseServer5Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer6Note3) && responseServer6Response3 == 0 &&
                    IsNullOrEmpty(responseServer6Cert3) && responseServer6Time3 == 0)
                {
                    responseServer6Response3 = response.responseServerResponse3;
                    responseServer6Note3 = response.responseServerNote3;
                    responseServer6Time3 = response.responseServerTime3;
                    responseServer6Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer7Note3) && responseServer7Response3 == 0 &&
                    IsNullOrEmpty(responseServer7Cert3) && responseServer7Time3 == 0)
                {
                    responseServer7Response3 = response.responseServerResponse3;
                    responseServer7Note3 = response.responseServerNote3;
                    responseServer7Time3 = response.responseServerTime3;
                    responseServer7Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer8Note3) && responseServer8Response3 == 0 &&
                    IsNullOrEmpty(responseServer8Cert3) && responseServer8Time3 == 0)
                {
                    responseServer8Response3 = response.responseServerResponse3;
                    responseServer8Note3 = response.responseServerNote3;
                    responseServer8Time3 = response.responseServerTime3;
                    responseServer8Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer9Note3) && responseServer9Response3 == 0 &&
                    IsNullOrEmpty(responseServer9Cert3) && responseServer9Time3 == 0)
                {
                    responseServer9Response3 = response.responseServerResponse3;
                    responseServer9Note3 = response.responseServerNote3;
                    responseServer9Time3 = response.responseServerTime3;
                    responseServer9Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer10Note3) && responseServer10Response3 == 0 &&
                    IsNullOrEmpty(responseServer10Cert3) && responseServer10Time3 == 0)
                {
                    responseServer10Response3 = response.responseServerResponse3;
                    responseServer10Note3 = response.responseServerNote3;
                    responseServer10Time3 = response.responseServerTime3;
                    responseServer10Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer11Note3) && responseServer11Response3 == 0 &&
                    IsNullOrEmpty(responseServer11Cert3) && responseServer11Time3 == 0)
                {
                    responseServer11Response3 = response.responseServerResponse3;
                    responseServer11Note3 = response.responseServerNote3;
                    responseServer11Time3 = response.responseServerTime3;
                    responseServer11Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer12Note3) && responseServer12Response3 == 0 &&
                    IsNullOrEmpty(responseServer12Cert3) && responseServer12Time3 == 0)
                {
                    responseServer12Response3 = response.responseServerResponse3;
                    responseServer12Note3 = response.responseServerNote3;
                    responseServer12Time3 = response.responseServerTime3;
                    responseServer12Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer13Note3) && responseServer13Response3 == 0 &&
                    IsNullOrEmpty(responseServer13Cert3) && responseServer13Time3 == 0)
                {
                    responseServer13Response3 = response.responseServerResponse3;
                    responseServer13Note3 = response.responseServerNote3;
                    responseServer13Time3 = response.responseServerTime3;
                    responseServer13Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer14Note3) && responseServer14Response3 == 0 &&
                    IsNullOrEmpty(responseServer14Cert3) && responseServer14Time3 == 0)
                {
                    responseServer14Response3 = response.responseServerResponse3;
                    responseServer14Note3 = response.responseServerNote3;
                    responseServer14Time3 = response.responseServerTime3;
                    responseServer14Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer15Note3) && responseServer15Response3 == 0 &&
                    IsNullOrEmpty(responseServer15Cert3) && responseServer15Time3 == 0)
                {
                    responseServer15Response3 = response.responseServerResponse3;
                    responseServer15Note3 = response.responseServerNote3;
                    responseServer15Time3 = response.responseServerTime3;
                    responseServer15Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer16Note3) && responseServer16Response3 == 0 &&
                    IsNullOrEmpty(responseServer16Cert3) && responseServer16Time3 == 0)
                {
                    responseServer16Response3 = response.responseServerResponse3;
                    responseServer16Note3 = response.responseServerNote3;
                    responseServer16Time3 = response.responseServerTime3;
                    responseServer16Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer17Note3) && responseServer17Response3 == 0 &&
                    IsNullOrEmpty(responseServer17Cert3) && responseServer17Time3 == 0)
                {
                    responseServer17Response3 = response.responseServerResponse3;
                    responseServer17Note3 = response.responseServerNote3;
                    responseServer17Time3 = response.responseServerTime3;
                    responseServer17Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer18Note3) && responseServer18Response3 == 0 &&
                    IsNullOrEmpty(responseServer18Cert3) && responseServer18Time3 == 0)
                {
                    responseServer18Response3 = response.responseServerResponse3;
                    responseServer18Note3 = response.responseServerNote3;
                    responseServer18Time3 = response.responseServerTime3;
                    responseServer18Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer19Note3) && responseServer19Response3 == 0 &&
                    IsNullOrEmpty(responseServer19Cert3) && responseServer19Time3 == 0)
                {
                    responseServer19Response3 = response.responseServerResponse3;
                    responseServer19Note3 = response.responseServerNote3;
                    responseServer19Time3 = response.responseServerTime3;
                    responseServer19Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer20Note3) && responseServer20Response3 == 0 &&
                    IsNullOrEmpty(responseServer20Cert3) && responseServer20Time3 == 0)
                {
                    responseServer20Response3 = response.responseServerResponse3;
                    responseServer20Note3 = response.responseServerNote3;
                    responseServer20Time3 = response.responseServerTime3;
                    responseServer20Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer21Note3) && responseServer21Response3 == 0 &&
                    IsNullOrEmpty(responseServer21Cert3) && responseServer21Time3 == 0)
                {
                    responseServer21Response3 = response.responseServerResponse3;
                    responseServer21Note3 = response.responseServerNote3;
                    responseServer21Time3 = response.responseServerTime3;
                    responseServer21Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer22Note3) && responseServer22Response3 == 0 &&
                    IsNullOrEmpty(responseServer22Cert3) && responseServer22Time3 == 0)
                {
                    responseServer22Response3 = response.responseServerResponse3;
                    responseServer22Note3 = response.responseServerNote3;
                    responseServer22Time3 = response.responseServerTime3;
                    responseServer22Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer23Note3) && responseServer23Response3 == 0 &&
                    IsNullOrEmpty(responseServer23Cert3) && responseServer23Time3 == 0)
                {
                    responseServer23Response3 = response.responseServerResponse3;
                    responseServer23Note3 = response.responseServerNote3;
                    responseServer23Time3 = response.responseServerTime3;
                    responseServer23Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer24Note3) && responseServer24Response3 == 0 &&
                    IsNullOrEmpty(responseServer24Cert3) && responseServer24Time3 == 0)
                {
                    responseServer24Response3 = response.responseServerResponse3;
                    responseServer24Note3 = response.responseServerNote3;
                    responseServer24Time3 = response.responseServerTime3;
                    responseServer24Cert3 = response.responseServerCert3;
                    continue;
                }

                if (IsNullOrEmpty(responseServer25Note3) && responseServer25Response3 == 0 &&
                    IsNullOrEmpty(responseServer25Cert3) && responseServer25Time3 == 0)
                {
                    responseServer25Response3 = response.responseServerResponse3;
                    responseServer25Note3 = response.responseServerNote3;
                    responseServer25Time3 = response.responseServerTime3;
                    responseServer25Cert3 = response.responseServerCert3;
                    continue;
                }
            }
        }

        if (response1 is { Count: > 0 } && response2 is { Count: > 0 } && response3 is { Count: > 0 })
        {
            log.LogInformation("Summing up final collection of server responses");

            var server1 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerOne,
                responseServerCert = responseServer1Cert1,
                responseServerCert2 = responseServer1Cert2,
                responseServerCert3 = responseServer1Cert3,
                responseServerNote = responseServer1Note1,
                responseServerNote2 = responseServer1Note2,
                responseServerNote3 = responseServer1Note3,
                responseServerResponse = responseServer1Response1,
                responseServerResponse2 = responseServer1Response2,
                responseServerResponse3 = responseServer1Response3,
                responseServerTime = responseServer1Time1,
                responseServerTime2 = responseServer1Time2,
                responseServerTime3 = responseServer1Time3
            };

            masterResponse.Add(server1);

            var server2 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerTwo,
                responseServerCert = responseServer2Cert1,
                responseServerCert2 = responseServer2Cert2,
                responseServerCert3 = responseServer2Cert3,
                responseServerNote = responseServer2Note1,
                responseServerNote2 = responseServer2Note2,
                responseServerNote3 = responseServer2Note3,
                responseServerResponse = responseServer2Response1,
                responseServerResponse2 = responseServer2Response2,
                responseServerResponse3 = responseServer2Response3,
                responseServerTime = responseServer2Time1,
                responseServerTime2 = responseServer2Time2,
                responseServerTime3 = responseServer2Time3
            };

            masterResponse.Add(server2);

            var server3 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerThree,
                responseServerCert = responseServer3Cert1,
                responseServerCert2 = responseServer3Cert2,
                responseServerCert3 = responseServer3Cert3,
                responseServerNote = responseServer3Note1,
                responseServerNote2 = responseServer3Note2,
                responseServerNote3 = responseServer3Note3,
                responseServerResponse = responseServer3Response1,
                responseServerResponse2 = responseServer3Response2,
                responseServerResponse3 = responseServer3Response3,
                responseServerTime = responseServer3Time1,
                responseServerTime2 = responseServer3Time2,
                responseServerTime3 = responseServer3Time3
            };

            masterResponse.Add(server3);

            var server4 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerFour,
                responseServerCert = responseServer4Cert1,
                responseServerCert2 = responseServer4Cert2,
                responseServerCert3 = responseServer4Cert3,
                responseServerNote = responseServer4Note1,
                responseServerNote2 = responseServer4Note2,
                responseServerNote3 = responseServer4Note3,
                responseServerResponse = responseServer4Response1,
                responseServerResponse2 = responseServer4Response2,
                responseServerResponse3 = responseServer4Response3,
                responseServerTime = responseServer4Time1,
                responseServerTime2 = responseServer4Time2,
                responseServerTime3 = responseServer4Time3
            };

            masterResponse.Add(server4);

            var server5 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerFive,
                responseServerCert = responseServer5Cert1,
                responseServerCert2 = responseServer5Cert2,
                responseServerCert3 = responseServer5Cert3,
                responseServerNote = responseServer5Note1,
                responseServerNote2 = responseServer5Note2,
                responseServerNote3 = responseServer5Note3,
                responseServerResponse = responseServer5Response1,
                responseServerResponse2 = responseServer5Response2,
                responseServerResponse3 = responseServer5Response3,
                responseServerTime = responseServer5Time1,
                responseServerTime2 = responseServer5Time2,
                responseServerTime3 = responseServer5Time3
            };

            masterResponse.Add(server5);

            var server6 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerSix,
                responseServerCert = responseServer6Cert1,
                responseServerCert2 = responseServer6Cert2,
                responseServerCert3 = responseServer6Cert3,
                responseServerNote = responseServer6Note1,
                responseServerNote2 = responseServer6Note2,
                responseServerNote3 = responseServer6Note3,
                responseServerResponse = responseServer6Response1,
                responseServerResponse2 = responseServer6Response2,
                responseServerResponse3 = responseServer6Response3,
                responseServerTime = responseServer6Time1,
                responseServerTime2 = responseServer6Time2,
                responseServerTime3 = responseServer6Time3
            };

            masterResponse.Add(server6);

            var server7 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerSeven,
                responseServerCert = responseServer7Cert1,
                responseServerCert2 = responseServer7Cert2,
                responseServerCert3 = responseServer7Cert3,
                responseServerNote = responseServer7Note1,
                responseServerNote2 = responseServer7Note2,
                responseServerNote3 = responseServer7Note3,
                responseServerResponse = responseServer7Response1,
                responseServerResponse2 = responseServer7Response2,
                responseServerResponse3 = responseServer7Response3,
                responseServerTime = responseServer7Time1,
                responseServerTime2 = responseServer7Time2,
                responseServerTime3 = responseServer7Time3
            };

            masterResponse.Add(server7);

            var server8 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerEight,
                responseServerCert = responseServer8Cert1,
                responseServerCert2 = responseServer8Cert2,
                responseServerCert3 = responseServer8Cert3,
                responseServerNote = responseServer8Note1,
                responseServerNote2 = responseServer8Note2,
                responseServerNote3 = responseServer8Note3,
                responseServerResponse = responseServer8Response1,
                responseServerResponse2 = responseServer8Response2,
                responseServerResponse3 = responseServer8Response3,
                responseServerTime = responseServer8Time1,
                responseServerTime2 = responseServer8Time2,
                responseServerTime3 = responseServer8Time3
            };

            masterResponse.Add(server8);

            var server9 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerNine,
                responseServerCert = responseServer9Cert1,
                responseServerCert2 = responseServer9Cert2,
                responseServerCert3 = responseServer9Cert3,
                responseServerNote = responseServer9Note1,
                responseServerNote2 = responseServer9Note2,
                responseServerNote3 = responseServer9Note3,
                responseServerResponse = responseServer9Response1,
                responseServerResponse2 = responseServer9Response2,
                responseServerResponse3 = responseServer9Response3,
                responseServerTime = responseServer9Time1,
                responseServerTime2 = responseServer9Time2,
                responseServerTime3 = responseServer9Time3
            };

            masterResponse.Add(server9);

            var server10 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerTen,
                responseServerCert = responseServer10Cert1,
                responseServerCert2 = responseServer10Cert2,
                responseServerCert3 = responseServer10Cert3,
                responseServerNote = responseServer10Note1,
                responseServerNote2 = responseServer10Note2,
                responseServerNote3 = responseServer10Note3,
                responseServerResponse = responseServer10Response1,
                responseServerResponse2 = responseServer10Response2,
                responseServerResponse3 = responseServer10Response3,
                responseServerTime = responseServer10Time1,
                responseServerTime2 = responseServer10Time2,
                responseServerTime3 = responseServer10Time3
            };

            masterResponse.Add(server10);

            var server11 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerEleven,
                responseServerCert = responseServer11Cert1,
                responseServerCert2 = responseServer11Cert2,
                responseServerCert3 = responseServer11Cert3,
                responseServerNote = responseServer11Note1,
                responseServerNote2 = responseServer11Note2,
                responseServerNote3 = responseServer11Note3,
                responseServerResponse = responseServer11Response1,
                responseServerResponse2 = responseServer11Response2,
                responseServerResponse3 = responseServer11Response3,
                responseServerTime = responseServer11Time1,
                responseServerTime2 = responseServer11Time2,
                responseServerTime3 = responseServer11Time3
            };

            masterResponse.Add(server11);

            var server12 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerTwelve,
                responseServerCert = responseServer12Cert1,
                responseServerCert2 = responseServer12Cert2,
                responseServerCert3 = responseServer12Cert3,
                responseServerNote = responseServer12Note1,
                responseServerNote2 = responseServer12Note2,
                responseServerNote3 = responseServer12Note3,
                responseServerResponse = responseServer12Response1,
                responseServerResponse2 = responseServer12Response2,
                responseServerResponse3 = responseServer12Response3,
                responseServerTime = responseServer12Time1,
                responseServerTime2 = responseServer12Time2,
                responseServerTime3 = responseServer12Time3
            };

            masterResponse.Add(server12);

            var server13 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerThirteen,
                responseServerCert = responseServer13Cert1,
                responseServerCert2 = responseServer13Cert2,
                responseServerCert3 = responseServer13Cert3,
                responseServerNote = responseServer13Note1,
                responseServerNote2 = responseServer13Note2,
                responseServerNote3 = responseServer13Note3,
                responseServerResponse = responseServer13Response1,
                responseServerResponse2 = responseServer13Response2,
                responseServerResponse3 = responseServer13Response3,
                responseServerTime = responseServer13Time1,
                responseServerTime2 = responseServer13Time2,
                responseServerTime3 = responseServer13Time3
            };

            masterResponse.Add(server13);

            var server14 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerFourteen,
                responseServerCert = responseServer14Cert1,
                responseServerCert2 = responseServer14Cert2,
                responseServerCert3 = responseServer14Cert3,
                responseServerNote = responseServer14Note1,
                responseServerNote2 = responseServer14Note2,
                responseServerNote3 = responseServer14Note3,
                responseServerResponse = responseServer14Response1,
                responseServerResponse2 = responseServer14Response2,
                responseServerResponse3 = responseServer14Response3,
                responseServerTime = responseServer14Time1,
                responseServerTime2 = responseServer14Time2,
                responseServerTime3 = responseServer14Time3
            };

            masterResponse.Add(server14);

            var server15 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerFifteen,
                responseServerCert = responseServer15Cert1,
                responseServerCert2 = responseServer15Cert2,
                responseServerCert3 = responseServer15Cert3,
                responseServerNote = responseServer15Note1,
                responseServerNote2 = responseServer15Note2,
                responseServerNote3 = responseServer15Note3,
                responseServerResponse = responseServer15Response1,
                responseServerResponse2 = responseServer15Response2,
                responseServerResponse3 = responseServer15Response3,
                responseServerTime = responseServer15Time1,
                responseServerTime2 = responseServer15Time2,
                responseServerTime3 = responseServer15Time3
            };

            masterResponse.Add(server15);

            var server16 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerSixteen,
                responseServerCert = responseServer16Cert1,
                responseServerCert2 = responseServer16Cert2,
                responseServerCert3 = responseServer16Cert3,
                responseServerNote = responseServer16Note1,
                responseServerNote2 = responseServer16Note2,
                responseServerNote3 = responseServer16Note3,
                responseServerResponse = responseServer16Response1,
                responseServerResponse2 = responseServer16Response2,
                responseServerResponse3 = responseServer16Response3,
                responseServerTime = responseServer16Time1,
                responseServerTime2 = responseServer16Time2,
                responseServerTime3 = responseServer16Time3
            };

            masterResponse.Add(server16);

            var server17 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerSeventeen,
                responseServerCert = responseServer17Cert1,
                responseServerCert2 = responseServer17Cert2,
                responseServerCert3 = responseServer17Cert3,
                responseServerNote = responseServer17Note1,
                responseServerNote2 = responseServer17Note2,
                responseServerNote3 = responseServer17Note3,
                responseServerResponse = responseServer17Response1,
                responseServerResponse2 = responseServer17Response2,
                responseServerResponse3 = responseServer17Response3,
                responseServerTime = responseServer17Time1,
                responseServerTime2 = responseServer17Time2,
                responseServerTime3 = responseServer17Time3
            };

            masterResponse.Add(server17);

            var server18 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerEighteen,
                responseServerCert = responseServer18Cert1,
                responseServerCert2 = responseServer18Cert2,
                responseServerCert3 = responseServer18Cert3,
                responseServerNote = responseServer18Note1,
                responseServerNote2 = responseServer18Note2,
                responseServerNote3 = responseServer18Note3,
                responseServerResponse = responseServer18Response1,
                responseServerResponse2 = responseServer18Response2,
                responseServerResponse3 = responseServer18Response3,
                responseServerTime = responseServer18Time1,
                responseServerTime2 = responseServer18Time2,
                responseServerTime3 = responseServer18Time3
            };

            masterResponse.Add(server18);

            var server19 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerNineteen,
                responseServerCert = responseServer19Cert1,
                responseServerCert2 = responseServer19Cert2,
                responseServerCert3 = responseServer19Cert3,
                responseServerNote = responseServer19Note1,
                responseServerNote2 = responseServer19Note2,
                responseServerNote3 = responseServer19Note3,
                responseServerResponse = responseServer19Response1,
                responseServerResponse2 = responseServer19Response2,
                responseServerResponse3 = responseServer19Response3,
                responseServerTime = responseServer19Time1,
                responseServerTime2 = responseServer19Time2,
                responseServerTime3 = responseServer19Time3
            };

            masterResponse.Add(server19);

            var server20 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerTwenty,
                responseServerCert = responseServer20Cert1,
                responseServerCert2 = responseServer20Cert2,
                responseServerCert3 = responseServer20Cert3,
                responseServerNote = responseServer20Note1,
                responseServerNote2 = responseServer20Note2,
                responseServerNote3 = responseServer20Note3,
                responseServerResponse = responseServer20Response1,
                responseServerResponse2 = responseServer20Response2,
                responseServerResponse3 = responseServer20Response3,
                responseServerTime = responseServer20Time1,
                responseServerTime2 = responseServer20Time2,
                responseServerTime3 = responseServer20Time3
            };

            masterResponse.Add(server20);

            var server21 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerTwentyOne,
                responseServerCert = responseServer21Cert1,
                responseServerCert2 = responseServer21Cert2,
                responseServerCert3 = responseServer21Cert3,
                responseServerNote = responseServer21Note1,
                responseServerNote2 = responseServer21Note2,
                responseServerNote3 = responseServer21Note3,
                responseServerResponse = responseServer21Response1,
                responseServerResponse2 = responseServer21Response2,
                responseServerResponse3 = responseServer21Response3,
                responseServerTime = responseServer21Time1,
                responseServerTime2 = responseServer21Time2,
                responseServerTime3 = responseServer21Time3
            };

            masterResponse.Add(server21);

            var server22 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerTwentyTwo,
                responseServerCert = responseServer22Cert1,
                responseServerCert2 = responseServer22Cert2,
                responseServerCert3 = responseServer22Cert3,
                responseServerNote = responseServer22Note1,
                responseServerNote2 = responseServer22Note2,
                responseServerNote3 = responseServer22Note3,
                responseServerResponse = responseServer22Response1,
                responseServerResponse2 = responseServer22Response2,
                responseServerResponse3 = responseServer22Response3,
                responseServerTime = responseServer22Time1,
                responseServerTime2 = responseServer22Time2,
                responseServerTime3 = responseServer22Time3
            };

            masterResponse.Add(server22);

            var server23 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerTwentyThree,
                responseServerCert = responseServer23Cert1,
                responseServerCert2 = responseServer23Cert2,
                responseServerCert3 = responseServer23Cert3,
                responseServerNote = responseServer23Note1,
                responseServerNote2 = responseServer23Note2,
                responseServerNote3 = responseServer23Note3,
                responseServerResponse = responseServer23Response1,
                responseServerResponse2 = responseServer23Response2,
                responseServerResponse3 = responseServer23Response3,
                responseServerTime = responseServer23Time1,
                responseServerTime2 = responseServer23Time2,
                responseServerTime3 = responseServer23Time3
            };

            masterResponse.Add(server23);

            var server24 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerTwentyFour,
                responseServerCert = responseServer24Cert1,
                responseServerCert2 = responseServer24Cert2,
                responseServerCert3 = responseServer24Cert3,
                responseServerNote = responseServer24Note1,
                responseServerNote2 = responseServer24Note2,
                responseServerNote3 = responseServer24Note3,
                responseServerResponse = responseServer24Response1,
                responseServerResponse2 = responseServer24Response2,
                responseServerResponse3 = responseServer24Response3,
                responseServerTime = responseServer24Time1,
                responseServerTime2 = responseServer24Time2,
                responseServerTime3 = responseServer24Time3
            };

            masterResponse.Add(server24);

            var server25 = new QueryResponse()
            {
                date = DateTime.Now,
                responseServer = responseServerTwentyFive,
                responseServerCert = responseServer25Cert1,
                responseServerCert2 = responseServer25Cert2,
                responseServerCert3 = responseServer25Cert3,
                responseServerNote = responseServer25Note1,
                responseServerNote2 = responseServer25Note2,
                responseServerNote3 = responseServer25Note3,
                responseServerResponse = responseServer25Response1,
                responseServerResponse2 = responseServer25Response2,
                responseServerResponse3 = responseServer25Response3,
                responseServerTime = responseServer25Time1,
                responseServerTime2 = responseServer25Time2,
                responseServerTime3 = responseServer25Time3
            };

            masterResponse.Add(server25);
        }
        else
        {
            log.LogInformation("Problem with Servers to be Queried.");
            return new BadRequestResult();
        }

        try
        {
            var tableResult = await WriteTableAsync(masterResponse, log).ConfigureAwait(false);

            log.LogInformation("Table write was " + tableResult + " update writing to storage!");
        }
        catch (Exception e)
        {
            log.LogInformation($"Error writing to Tables {e.Message} and {e.Data}");
        }

        log.LogInformation("Returning final result back to app to be processed on device.");

        return new JsonResult(masterResponse);
    }


    public async Task<List<QueryResponse>> DoQuery(List<QueryServers> server, Uri funcUrl, ILogger log)
    {
        log.LogInformation("Made It Into DoQuery!");

        BaseUrl = funcUrl;

        var content = new JsonHelper(server);

        log.LogInformation(server.ToString());

        try
        {
            var response = await _httpClient.PostAsync(BaseUrl, content).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                log.LogInformation("Response was invalid! or the Function Had Issues");
                return null;
            }

            await using var stream = await response.Content.ReadAsStreamAsync();
            using var reader = new StreamReader(stream);
            using var jsonReader = new JsonTextReader(reader);

            var result = await response.Content.ReadAsStringAsync(cancellationToken: CancellationToken.None)
                .ConfigureAwait(false);

            log.LogInformation("Raw Output Should Be " + result);

            log.LogInformation("Returning Deserialized QueryResponse From The Server.");
            return _serializer.Deserialize<List<QueryResponse>>(jsonReader);
        }
        catch (HttpRequestException e)
        {
            log.LogInformation("Error in Function Request " + e.Message + " " + e.Data);
            return null;
        }
        catch (Exception e)
        {
            log.LogInformation("Some Error in Function Request " + e.Message + " " + e.Data);
            return null;
        }
    }

    private async Task<bool> WriteTableAsync(List<QueryResponse> response, ILogger log)
    {
        var partitionKey = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        
        _storageAccount = CloudStorageAccount.Parse(_connectionString);
        _tableClient = _storageAccount.CreateCloudTableClient();
        _table = _tableClient.GetTableReference("QueryResults");
        var tableResult = await _table.ExistsAsync();

        if (!tableResult)
        {
            log.LogInformation("Table Does Not Exist, Creating Table!");
            await _table.CreateIfNotExistsAsync();
        }

        var logEntity = new DynamicTableEntity
        {
            PartitionKey = IpAddress,
            RowKey = partitionKey,
        };

        // Add the properties of the QueryResponse object to the logEntity.
        foreach (var prop in response.GetType().GetProperties())
        {
            if (prop.PropertyType == typeof(DateTime))
            {
                if (prop != null)
                {
                    var dateTime = (DateTime)prop.GetValue(response)!;
                    logEntity.Properties.Add(prop.Name,
                        EntityProperty.CreateEntityPropertyFromObject(dateTime.ToUniversalTime().ToString("o")));
                }
            }
            else
            {
                logEntity.Properties.Add(prop.Name,
                    EntityProperty.CreateEntityPropertyFromObject(prop.GetValue(response)));
            }
        }

        // Insert the log entry into the table
        var insertOperation = TableOperation.Insert(logEntity);
        var result = await _table.ExecuteAsync(insertOperation);
        
        log.LogInformation("Inserted Row Into Table Now Return Control To Function!");

        return result.HttpStatusCode is >= 200 and <= 299;
    }
}
