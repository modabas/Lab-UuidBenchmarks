using BenchmarkDotNet.Running;
using Medo;
using System.Collections.Concurrent;
using UuidBenchmarks;

#region "Benchmark"
var summary = BenchmarkRunner.Run<UuidBenchmarks.UuidBenchmarks>();
#endregion

#region "Uuid generation"
//var medoUuid = Uuid7.NewUuid7();
//Console.WriteLine($"medoUuid: {medoUuid}");

//var uuidNext = UuidNext.New7();
//Console.WriteLine($"uuidNext: {uuidNext}");

//var nGuid = UuidBenchmarks.NGuid.New7();
//Console.WriteLine($"nGuid: {nGuid}");

//var guidPlus = UuidBenchmarks.GuidPlus.New7();
//Console.WriteLine($"guidPlus: {guidPlus}");
#endregion

#region "Extensions"
//var uuidNext2 = UuidNext.New7();
//Console.WriteLine($"uuidNext: {uuidNext2}");
//Console.WriteLine($"uuidNext is V7: {uuidNext2.IsV7()}");
//Console.WriteLine($"uuidNext timestamp: {uuidNext2.ToDateTimeOffset()}");

//var nGuid2 = UuidBenchmarks.NGuid.New7();
//Console.WriteLine($"nGuid: {nGuid2}");
//Console.WriteLine($"nGuid is V7: {nGuid2.IsV7()}");
//Console.WriteLine($"nGuid timestamp: {nGuid2.ToDateTimeOffset()}");
#endregion

#region "Single thread multiple Uuid generation"
//Console.WriteLine("medoUuid");
//for (var i = 0; i < 10; i++)
//{
//    Console.WriteLine($"{i}: {Uuid7.NewUuid7()}");
//}

//Console.WriteLine("uuidNext");
//for (var i = 0; i < 10; i++)
//{
//    Console.WriteLine($"{i}: {UuidNext.New7()}");
//}

//Console.WriteLine("nGuid");
//for (var i = 0; i < 10; i++)
//{
//    Console.WriteLine($"{i}: {UuidBenchmarks.NGuid.New7()}");
//}
#endregion
