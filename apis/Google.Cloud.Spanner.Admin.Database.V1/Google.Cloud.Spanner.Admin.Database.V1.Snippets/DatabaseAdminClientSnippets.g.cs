// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Cloud.Spanner.Admin.Database.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Cloud.Iam.V1;
    using Google.Cloud.Spanner.Common.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedDatabaseAdminClientSnippets
    {
        /// <summary>Snippet for ListDatabases</summary>
        public void ListDatabasesRequestObject()
        {
            // Snippet: ListDatabases(ListDatabasesRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            PagedEnumerable<ListDatabasesResponse, Database> response = databaseAdminClient.ListDatabases(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Database item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatabasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Database item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Database> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Database item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabases</summary>
        public async Task ListDatabasesRequestObjectAsync()
        {
            // Snippet: ListDatabasesAsync(ListDatabasesRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDatabasesResponse, Database> response = databaseAdminClient.ListDatabasesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Database item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatabasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Database item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Database> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Database item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabases</summary>
        public void ListDatabases()
        {
            // Snippet: ListDatabases(string, string, int?, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListDatabasesResponse, Database> response = databaseAdminClient.ListDatabases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Database item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatabasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Database item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Database> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Database item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabases</summary>
        public async Task ListDatabasesAsync()
        {
            // Snippet: ListDatabasesAsync(string, string, int?, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListDatabasesResponse, Database> response = databaseAdminClient.ListDatabasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Database item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatabasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Database item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Database> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Database item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabases</summary>
        public void ListDatabasesResourceNames()
        {
            // Snippet: ListDatabases(InstanceName, string, int?, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListDatabasesResponse, Database> response = databaseAdminClient.ListDatabases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Database item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatabasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Database item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Database> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Database item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabases</summary>
        public async Task ListDatabasesResourceNamesAsync()
        {
            // Snippet: ListDatabasesAsync(InstanceName, string, int?, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListDatabasesResponse, Database> response = databaseAdminClient.ListDatabasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Database item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatabasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Database item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Database> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Database item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateDatabase</summary>
        public void CreateDatabaseRequestObject()
        {
            // Snippet: CreateDatabase(CreateDatabaseRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            CreateDatabaseRequest request = new CreateDatabaseRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                CreateStatement = "",
                ExtraStatements = { "", },
            };
            // Make the request
            Operation<Database, CreateDatabaseMetadata> response = databaseAdminClient.CreateDatabase(request);

            // Poll until the returned long-running operation is complete
            Operation<Database, CreateDatabaseMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, CreateDatabaseMetadata> retrievedResponse = databaseAdminClient.PollOnceCreateDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatabaseAsync</summary>
        public async Task CreateDatabaseRequestObjectAsync()
        {
            // Snippet: CreateDatabaseAsync(CreateDatabaseRequest, CallSettings)
            // Additional: CreateDatabaseAsync(CreateDatabaseRequest, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateDatabaseRequest request = new CreateDatabaseRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                CreateStatement = "",
                ExtraStatements = { "", },
            };
            // Make the request
            Operation<Database, CreateDatabaseMetadata> response = await databaseAdminClient.CreateDatabaseAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Database, CreateDatabaseMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, CreateDatabaseMetadata> retrievedResponse = await databaseAdminClient.PollOnceCreateDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatabase</summary>
        public void CreateDatabase()
        {
            // Snippet: CreateDatabase(string, string, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            string createStatement = "";
            // Make the request
            Operation<Database, CreateDatabaseMetadata> response = databaseAdminClient.CreateDatabase(parent, createStatement);

            // Poll until the returned long-running operation is complete
            Operation<Database, CreateDatabaseMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, CreateDatabaseMetadata> retrievedResponse = databaseAdminClient.PollOnceCreateDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatabaseAsync</summary>
        public async Task CreateDatabaseAsync()
        {
            // Snippet: CreateDatabaseAsync(string, string, CallSettings)
            // Additional: CreateDatabaseAsync(string, string, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            string createStatement = "";
            // Make the request
            Operation<Database, CreateDatabaseMetadata> response = await databaseAdminClient.CreateDatabaseAsync(parent, createStatement);

            // Poll until the returned long-running operation is complete
            Operation<Database, CreateDatabaseMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, CreateDatabaseMetadata> retrievedResponse = await databaseAdminClient.PollOnceCreateDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatabase</summary>
        public void CreateDatabaseResourceNames()
        {
            // Snippet: CreateDatabase(InstanceName, string, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            string createStatement = "";
            // Make the request
            Operation<Database, CreateDatabaseMetadata> response = databaseAdminClient.CreateDatabase(parent, createStatement);

            // Poll until the returned long-running operation is complete
            Operation<Database, CreateDatabaseMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, CreateDatabaseMetadata> retrievedResponse = databaseAdminClient.PollOnceCreateDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatabaseAsync</summary>
        public async Task CreateDatabaseResourceNamesAsync()
        {
            // Snippet: CreateDatabaseAsync(InstanceName, string, CallSettings)
            // Additional: CreateDatabaseAsync(InstanceName, string, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            string createStatement = "";
            // Make the request
            Operation<Database, CreateDatabaseMetadata> response = await databaseAdminClient.CreateDatabaseAsync(parent, createStatement);

            // Poll until the returned long-running operation is complete
            Operation<Database, CreateDatabaseMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, CreateDatabaseMetadata> retrievedResponse = await databaseAdminClient.PollOnceCreateDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetDatabase</summary>
        public void GetDatabaseRequestObject()
        {
            // Snippet: GetDatabase(GetDatabaseRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            // Make the request
            Database response = databaseAdminClient.GetDatabase(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseAsync</summary>
        public async Task GetDatabaseRequestObjectAsync()
        {
            // Snippet: GetDatabaseAsync(GetDatabaseRequest, CallSettings)
            // Additional: GetDatabaseAsync(GetDatabaseRequest, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            // Make the request
            Database response = await databaseAdminClient.GetDatabaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatabase</summary>
        public void GetDatabase()
        {
            // Snippet: GetDatabase(string, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            // Make the request
            Database response = databaseAdminClient.GetDatabase(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseAsync</summary>
        public async Task GetDatabaseAsync()
        {
            // Snippet: GetDatabaseAsync(string, CallSettings)
            // Additional: GetDatabaseAsync(string, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            // Make the request
            Database response = await databaseAdminClient.GetDatabaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatabase</summary>
        public void GetDatabaseResourceNames()
        {
            // Snippet: GetDatabase(DatabaseName, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            DatabaseName name = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            // Make the request
            Database response = databaseAdminClient.GetDatabase(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseAsync</summary>
        public async Task GetDatabaseResourceNamesAsync()
        {
            // Snippet: GetDatabaseAsync(DatabaseName, CallSettings)
            // Additional: GetDatabaseAsync(DatabaseName, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            DatabaseName name = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            // Make the request
            Database response = await databaseAdminClient.GetDatabaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatabaseDdl</summary>
        public void UpdateDatabaseDdlRequestObject()
        {
            // Snippet: UpdateDatabaseDdl(UpdateDatabaseDdlRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            UpdateDatabaseDdlRequest request = new UpdateDatabaseDdlRequest
            {
                DatabaseAsDatabaseName = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                Statements = { "", },
                OperationId = "",
            };
            // Make the request
            Operation<Empty, UpdateDatabaseDdlMetadata> response = databaseAdminClient.UpdateDatabaseDdl(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, UpdateDatabaseDdlMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, UpdateDatabaseDdlMetadata> retrievedResponse = databaseAdminClient.PollOnceUpdateDatabaseDdl(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatabaseDdlAsync</summary>
        public async Task UpdateDatabaseDdlRequestObjectAsync()
        {
            // Snippet: UpdateDatabaseDdlAsync(UpdateDatabaseDdlRequest, CallSettings)
            // Additional: UpdateDatabaseDdlAsync(UpdateDatabaseDdlRequest, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDatabaseDdlRequest request = new UpdateDatabaseDdlRequest
            {
                DatabaseAsDatabaseName = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                Statements = { "", },
                OperationId = "",
            };
            // Make the request
            Operation<Empty, UpdateDatabaseDdlMetadata> response = await databaseAdminClient.UpdateDatabaseDdlAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, UpdateDatabaseDdlMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, UpdateDatabaseDdlMetadata> retrievedResponse = await databaseAdminClient.PollOnceUpdateDatabaseDdlAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatabaseDdl</summary>
        public void UpdateDatabaseDdl()
        {
            // Snippet: UpdateDatabaseDdl(string, IEnumerable<string>, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            IEnumerable<string> statements = new string[] { "", };
            // Make the request
            Operation<Empty, UpdateDatabaseDdlMetadata> response = databaseAdminClient.UpdateDatabaseDdl(database, statements);

            // Poll until the returned long-running operation is complete
            Operation<Empty, UpdateDatabaseDdlMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, UpdateDatabaseDdlMetadata> retrievedResponse = databaseAdminClient.PollOnceUpdateDatabaseDdl(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatabaseDdlAsync</summary>
        public async Task UpdateDatabaseDdlAsync()
        {
            // Snippet: UpdateDatabaseDdlAsync(string, IEnumerable<string>, CallSettings)
            // Additional: UpdateDatabaseDdlAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            IEnumerable<string> statements = new string[] { "", };
            // Make the request
            Operation<Empty, UpdateDatabaseDdlMetadata> response = await databaseAdminClient.UpdateDatabaseDdlAsync(database, statements);

            // Poll until the returned long-running operation is complete
            Operation<Empty, UpdateDatabaseDdlMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, UpdateDatabaseDdlMetadata> retrievedResponse = await databaseAdminClient.PollOnceUpdateDatabaseDdlAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatabaseDdl</summary>
        public void UpdateDatabaseDdlResourceNames()
        {
            // Snippet: UpdateDatabaseDdl(DatabaseName, IEnumerable<string>, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            DatabaseName database = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            IEnumerable<string> statements = new string[] { "", };
            // Make the request
            Operation<Empty, UpdateDatabaseDdlMetadata> response = databaseAdminClient.UpdateDatabaseDdl(database, statements);

            // Poll until the returned long-running operation is complete
            Operation<Empty, UpdateDatabaseDdlMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, UpdateDatabaseDdlMetadata> retrievedResponse = databaseAdminClient.PollOnceUpdateDatabaseDdl(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatabaseDdlAsync</summary>
        public async Task UpdateDatabaseDdlResourceNamesAsync()
        {
            // Snippet: UpdateDatabaseDdlAsync(DatabaseName, IEnumerable<string>, CallSettings)
            // Additional: UpdateDatabaseDdlAsync(DatabaseName, IEnumerable<string>, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            DatabaseName database = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            IEnumerable<string> statements = new string[] { "", };
            // Make the request
            Operation<Empty, UpdateDatabaseDdlMetadata> response = await databaseAdminClient.UpdateDatabaseDdlAsync(database, statements);

            // Poll until the returned long-running operation is complete
            Operation<Empty, UpdateDatabaseDdlMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, UpdateDatabaseDdlMetadata> retrievedResponse = await databaseAdminClient.PollOnceUpdateDatabaseDdlAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DropDatabase</summary>
        public void DropDatabaseRequestObject()
        {
            // Snippet: DropDatabase(DropDatabaseRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            DropDatabaseRequest request = new DropDatabaseRequest
            {
                DatabaseAsDatabaseName = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            // Make the request
            databaseAdminClient.DropDatabase(request);
            // End snippet
        }

        /// <summary>Snippet for DropDatabaseAsync</summary>
        public async Task DropDatabaseRequestObjectAsync()
        {
            // Snippet: DropDatabaseAsync(DropDatabaseRequest, CallSettings)
            // Additional: DropDatabaseAsync(DropDatabaseRequest, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            DropDatabaseRequest request = new DropDatabaseRequest
            {
                DatabaseAsDatabaseName = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            // Make the request
            await databaseAdminClient.DropDatabaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DropDatabase</summary>
        public void DropDatabase()
        {
            // Snippet: DropDatabase(string, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            // Make the request
            databaseAdminClient.DropDatabase(database);
            // End snippet
        }

        /// <summary>Snippet for DropDatabaseAsync</summary>
        public async Task DropDatabaseAsync()
        {
            // Snippet: DropDatabaseAsync(string, CallSettings)
            // Additional: DropDatabaseAsync(string, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            // Make the request
            await databaseAdminClient.DropDatabaseAsync(database);
            // End snippet
        }

        /// <summary>Snippet for DropDatabase</summary>
        public void DropDatabaseResourceNames()
        {
            // Snippet: DropDatabase(DatabaseName, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            DatabaseName database = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            // Make the request
            databaseAdminClient.DropDatabase(database);
            // End snippet
        }

        /// <summary>Snippet for DropDatabaseAsync</summary>
        public async Task DropDatabaseResourceNamesAsync()
        {
            // Snippet: DropDatabaseAsync(DatabaseName, CallSettings)
            // Additional: DropDatabaseAsync(DatabaseName, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            DatabaseName database = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            // Make the request
            await databaseAdminClient.DropDatabaseAsync(database);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseDdl</summary>
        public void GetDatabaseDdlRequestObject()
        {
            // Snippet: GetDatabaseDdl(GetDatabaseDdlRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            GetDatabaseDdlRequest request = new GetDatabaseDdlRequest
            {
                DatabaseAsDatabaseName = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            // Make the request
            GetDatabaseDdlResponse response = databaseAdminClient.GetDatabaseDdl(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseDdlAsync</summary>
        public async Task GetDatabaseDdlRequestObjectAsync()
        {
            // Snippet: GetDatabaseDdlAsync(GetDatabaseDdlRequest, CallSettings)
            // Additional: GetDatabaseDdlAsync(GetDatabaseDdlRequest, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetDatabaseDdlRequest request = new GetDatabaseDdlRequest
            {
                DatabaseAsDatabaseName = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            // Make the request
            GetDatabaseDdlResponse response = await databaseAdminClient.GetDatabaseDdlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseDdl</summary>
        public void GetDatabaseDdl()
        {
            // Snippet: GetDatabaseDdl(string, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            // Make the request
            GetDatabaseDdlResponse response = databaseAdminClient.GetDatabaseDdl(database);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseDdlAsync</summary>
        public async Task GetDatabaseDdlAsync()
        {
            // Snippet: GetDatabaseDdlAsync(string, CallSettings)
            // Additional: GetDatabaseDdlAsync(string, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            // Make the request
            GetDatabaseDdlResponse response = await databaseAdminClient.GetDatabaseDdlAsync(database);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseDdl</summary>
        public void GetDatabaseDdlResourceNames()
        {
            // Snippet: GetDatabaseDdl(DatabaseName, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            DatabaseName database = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            // Make the request
            GetDatabaseDdlResponse response = databaseAdminClient.GetDatabaseDdl(database);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseDdlAsync</summary>
        public async Task GetDatabaseDdlResourceNamesAsync()
        {
            // Snippet: GetDatabaseDdlAsync(DatabaseName, CallSettings)
            // Additional: GetDatabaseDdlAsync(DatabaseName, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            DatabaseName database = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            // Make the request
            GetDatabaseDdlResponse response = await databaseAdminClient.GetDatabaseDdlAsync(database);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = databaseAdminClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await databaseAdminClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, Policy, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = databaseAdminClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(string, Policy, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await databaseAdminClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = databaseAdminClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await databaseAdminClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = databaseAdminClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await databaseAdminClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = databaseAdminClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await databaseAdminClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = databaseAdminClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await databaseAdminClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = databaseAdminClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await databaseAdminClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, IEnumerable<string>, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = databaseAdminClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await databaseAdminClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = databaseAdminClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsResourceNamesAsync()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await databaseAdminClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }
    }
}
