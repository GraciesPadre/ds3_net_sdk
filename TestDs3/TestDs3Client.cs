﻿using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;

using Ds3.Runtime;
using Ds3.Models;
using System;
using Ds3;
using Ds3.AwsModels;

namespace TestDs3
{
    [TestFixture]
    public class TestDs3Client
    {
        private readonly IDictionary<string, string> _emptyQueryParams = new Dictionary<string, string>();

        [Test]
        public void TestGetService()
        {
            //TODO: XmlSerializer really doesn't like xmlns="http://doc.s3.amazonaws.com/2006-03-01"
            var responseContent = "<ListAllMyBucketsResult><Owner><ID>ryan</ID><DisplayName>ryan</DisplayName></Owner><Buckets><Bucket><Name>testBucket2</Name><CreationDate>2013-12-11T23:20:09</CreationDate></Bucket><Bucket><Name>bulkTest</Name><CreationDate>2013-12-11T23:20:09</CreationDate></Bucket><Bucket><Name>bulkTest1</Name><CreationDate>2013-12-11T23:20:09</CreationDate></Bucket><Bucket><Name>bulkTest2</Name><CreationDate>2013-12-11T23:20:09</CreationDate></Bucket><Bucket><Name>bulkTest3</Name><CreationDate>2013-12-11T23:20:09</CreationDate></Bucket><Bucket><Name>bulkTest4</Name><CreationDate>2013-12-11T23:20:09</CreationDate></Bucket><Bucket><Name>bulkTest5</Name><CreationDate>2013-12-11T23:20:09</CreationDate></Bucket><Bucket><Name>bulkTest6</Name><CreationDate>2013-12-11T23:20:09</CreationDate></Bucket><Bucket><Name>testBucket3</Name><CreationDate>2013-12-11T23:20:09</CreationDate></Bucket><Bucket><Name>testBucket1</Name><CreationDate>2013-12-11T23:20:09</CreationDate></Bucket><Bucket><Name>testbucket</Name><CreationDate>2013-12-11T23:20:09</CreationDate></Bucket></Buckets></ListAllMyBucketsResult>";
            var expectedBuckets = new[] {
                new { Key = "testBucket2",  CreationDate = "2013-12-11T23:20:09" },
                new { Key = "bulkTest",     CreationDate = "2013-12-11T23:20:09" },
                new { Key = "bulkTest1",    CreationDate = "2013-12-11T23:20:09" },
                new { Key = "bulkTest2",    CreationDate = "2013-12-11T23:20:09" },
                new { Key = "bulkTest3",    CreationDate = "2013-12-11T23:20:09" },
                new { Key = "bulkTest4",    CreationDate = "2013-12-11T23:20:09" },
                new { Key = "bulkTest5",    CreationDate = "2013-12-11T23:20:09" },
                new { Key = "bulkTest6",    CreationDate = "2013-12-11T23:20:09" },
                new { Key = "testBucket3",  CreationDate = "2013-12-11T23:20:09" },
                new { Key = "testBucket1",  CreationDate = "2013-12-11T23:20:09" },
                new { Key = "testbucket",   CreationDate = "2013-12-11T23:20:09" }
            };

            using (var response = MockNetwork
                .Expecting(HttpVerb.GET, "/", _emptyQueryParams, "")
                .Returning(HttpStatusCode.OK, responseContent)
                .AsClient
                .GetService(new GetServiceRequest()))
            {
                Assert.AreEqual("ryan", response.Owner.DisplayName);
                Assert.AreEqual("ryan", response.Owner.Id);

                Assert.AreEqual(expectedBuckets.Length, response.Buckets.Count);
                for (var i = 0; i < expectedBuckets.Length; i++)
                {
                    Assert.AreEqual(expectedBuckets[i].Key, response.Buckets[i].Name);
                    Assert.AreEqual(expectedBuckets[i].CreationDate, response.Buckets[i].CreationDate);
                }
            }
        }

        [Test]
        [ExpectedException(typeof(Ds3BadStatusCodeException))]
        public void TestGetBadService()
        {
            using (MockNetwork
                .Expecting(HttpVerb.GET, "/", _emptyQueryParams, "")
                .Returning(HttpStatusCode.BadRequest, "")
                .AsClient
                .GetService(new GetServiceRequest()))
            {
            }
        }

        [Test]
        public void TestGetBucket()
        {
            var xmlResponse = "<ListBucketResult><Name>remoteTest16</Name><Prefix/><Marker/><MaxKeys>1000</MaxKeys><IsTruncated>false</IsTruncated><Contents><Key>user/hduser/gutenberg/20417.txt.utf-8</Key><LastModified>2014-01-03T13:26:47.000Z</LastModified><ETag>NOTRETURNED</ETag><Size>674570</Size><StorageClass>STANDARD</StorageClass><Owner><ID>ryan</ID><DisplayName>ryan</DisplayName></Owner></Contents><Contents><Key>user/hduser/gutenberg/5000.txt.utf-8</Key><LastModified>2014-01-03T13:26:47.000Z</LastModified><ETag>NOTRETURNED</ETag><Size>1423803</Size><StorageClass>STANDARD</StorageClass><Owner><ID>ryan</ID><DisplayName>ryan</DisplayName></Owner></Contents><Contents><Key>user/hduser/gutenberg/4300.txt.utf-8</Key><LastModified>2014-01-03T13:26:47.000Z</LastModified><ETag>NOTRETURNED</ETag><Size>1573150</Size><StorageClass>STANDARD</StorageClass><Owner><ID>ryan</ID><DisplayName>ryan</DisplayName></Owner></Contents></ListBucketResult>";
            var expected = new {
                Name = "remoteTest16",
                Prefix = "",
                Marker = "",
                MaxKeys = 1000,
                IsTruncated = false,
                Objects = new[] {
                    new {
                        Key = "user/hduser/gutenberg/20417.txt.utf-8",
                        LastModified = DateTime.Parse("2014-01-03T13:26:47.000Z"),
                        ETag = "NOTRETURNED",
                        Size = 674570,
                        StorageClass = "STANDARD",
                        Owner = new { ID = "ryan", DisplayName = "ryan" }
                    },
                    new {
                        Key = "user/hduser/gutenberg/5000.txt.utf-8",
                        LastModified = DateTime.Parse("2014-01-03T13:26:47.000Z"),
                        ETag = "NOTRETURNED",
                        Size = 1423803,
                        StorageClass = "STANDARD",
                        Owner = new { ID = "ryan", DisplayName = "ryan" }
                    },
                    new {
                        Key = "user/hduser/gutenberg/4300.txt.utf-8",
                        LastModified = DateTime.Parse("2014-01-03T13:26:47.000Z"),
                        ETag = "NOTRETURNED",
                        Size = 1573150,
                        StorageClass = "STANDARD",
                        Owner = new { ID = "ryan", DisplayName = "ryan" }
                    }
                }
            };

            using (var response = MockNetwork
                .Expecting(HttpVerb.GET, "/remoteTest16", _emptyQueryParams, "")
                .Returning(HttpStatusCode.OK, xmlResponse)
                .AsClient
                .GetBucket(new GetBucketRequest("remoteTest16")))
            {
                Assert.AreEqual(expected.Name, response.Name);
                Assert.AreEqual(expected.Prefix, response.Prefix);
                Assert.AreEqual(expected.Marker, response.Marker);
                Assert.AreEqual(expected.MaxKeys, response.MaxKeys);
                Assert.AreEqual(expected.IsTruncated, response.IsTruncated);
                Assert.AreEqual(expected.Objects.Length, response.Objects.Count);
                for (var i = 0; i < expected.Objects.Length; i++)
                {
                    Assert.AreEqual(expected.Objects[i].Key, response.Objects[i].Name);
                    Assert.AreEqual(expected.Objects[i].LastModified, response.Objects[i].LastModified);
                    Assert.AreEqual(expected.Objects[i].ETag, response.Objects[i].Etag);
                    Assert.AreEqual(expected.Objects[i].Size, response.Objects[i].Size);
                    Assert.AreEqual(expected.Objects[i].StorageClass, response.Objects[i].StorageClass);
                    Assert.AreEqual(expected.Objects[i].Owner.ID, response.Objects[i].Owner.Id);
                    Assert.AreEqual(expected.Objects[i].Owner.DisplayName, response.Objects[i].Owner.DisplayName);
                }
            }
        }

        [Test]
        public void TestPutBucket()
        {
            using (MockNetwork
                .Expecting(HttpVerb.PUT, "/bucketName", _emptyQueryParams, "")
                .Returning(HttpStatusCode.OK, "")
                .AsClient
                .PutBucket(new PutBucketRequest("bucketName")))
            {
            }
        }

        [Test]
        public void TestDeleteBucket()
        {
            using (MockNetwork
                .Expecting(HttpVerb.DELETE, "/bucketName", _emptyQueryParams, "")
                .Returning(HttpStatusCode.NoContent, "")
                .AsClient
                .DeleteBucket(new DeleteBucketRequest("bucketName")))
            {
            }
        }

        [Test]
        public void TestDeleteObject()
        {
            using (MockNetwork
                .Expecting(HttpVerb.DELETE, "/bucketName/my/file.txt", _emptyQueryParams, "")
                .Returning(HttpStatusCode.NoContent, "")
                .AsClient
                .DeleteObject(new DeleteObjectRequest("bucketName", "my/file.txt")))
            {
            }
        }

        [Test]
        [ExpectedException(typeof(Ds3BadStatusCodeException))]
        public void TestGetBadBucket()
        {
            using (MockNetwork
                .Expecting(HttpVerb.GET, "/bucketName", _emptyQueryParams, "")
                .Returning(HttpStatusCode.BadRequest, "")
                .AsClient
                .GetBucket(new GetBucketRequest("bucketName")))
            {
            }
        }

        [Test]
        public void TestGetObject()
        {
            var stringResponse = "object contents";

            using (var response = MockNetwork
                .Expecting(HttpVerb.GET, "/bucketName/object", _emptyQueryParams, "")
                .Returning(HttpStatusCode.OK, stringResponse)
                .AsClient
                .GetObject(new GetObjectRequest("bucketName", "object")))
            using (var contents = response.Contents)
            using (var reader = new StreamReader(contents))
            {
                var actualStringResponse = reader.ReadToEnd();
                Assert.AreEqual(stringResponse, actualStringResponse);
            }
        }

        [Test]
        public void TestPutObject()
        {
            var stringRequest = "object content";

            using (MockNetwork
                .Expecting(HttpVerb.PUT, "/bucketName/object", _emptyQueryParams, stringRequest)
                .Returning(HttpStatusCode.OK, stringRequest)
                .AsClient
                .PutObject(new PutObjectRequest("bucketName", "object", Helpers.StringToStream(stringRequest))))
            {
            }
        }

        [Test]
        public void TestBulkPut()
        {
            runBulkTest("start_bulk_put", (client, objects) => client.BulkPut(new BulkPutRequest("bucketName", objects)));
        }

        [Test]
        public void TestBulkGet()
        {
            runBulkTest("start_bulk_get", (client, objects) => client.BulkGet(new BulkGetRequest("bucketName", objects)));
        }

        private void runBulkTest(string operation, Func<Ds3Client, List<Ds3Object>, BulkResponse> makeCall)
        {
            var expected = new[] {
                new { Key = "file2", Size = 1202 },
                new { Key = "file1", Size = 256 },
                new { Key = "file3", Size = 2523 }
            };

            var stringRequest = "<?xml version=\"1.0\"?>\r\n<objects xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\r\n  <object name=\"file1\" size=\"256\" />\r\n  <object name=\"file2\" size=\"1202\" />\r\n  <object name=\"file3\" size=\"2523\" />\r\n</objects>";
            var stringResponse = "<masterobjectlist><objects><object name='file2' size='1202'/><object name='file1' size='256'/><object name='file3' size='2523'/></objects></masterobjectlist>";

            var inputObjects = new List<Ds3Object> {
                new Ds3Object("file1", 256),
                new Ds3Object("file2", 1202),
                new Ds3Object("file3", 2523)
            };

            var queryParams = new Dictionary<string, string>() { { "operation", operation } };
            var client = MockNetwork
                .Expecting(HttpVerb.PUT, "/_rest_/buckets/bucketName", queryParams, stringRequest)
                .Returning(HttpStatusCode.OK, stringResponse)
                .AsClient;

            using (var response = makeCall(client, inputObjects))
            {
                Assert.AreEqual(1, response.ObjectLists.Count);
                for (var i = 0; i < expected.Length; i++)
                {
                    Assert.AreEqual(expected[i].Key, response.ObjectLists[0][i].Name);
                    Assert.AreEqual(expected[i].Size, response.ObjectLists[0][i].Size);
                }
            }
        }
    }
}