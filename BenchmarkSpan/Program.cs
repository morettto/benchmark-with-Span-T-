using BenchmarkDotNet.Running;
using BenchmarkSpan;

BenchmarkRunner.Run<BinaryDataOperations>();
BenchmarkRunner.Run<StringProcessing>();
BenchmarkRunner.Run<ArrayOperations>();
