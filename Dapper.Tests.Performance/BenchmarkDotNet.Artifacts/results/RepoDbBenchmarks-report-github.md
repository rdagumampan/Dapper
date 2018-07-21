``` ini

BenchmarkDotNet=v0.10.9, OS=Windows 8.1 (6.3.9600)
Processor=Intel Core i7-4810MQ CPU 2.80GHz (Haswell), ProcessorCount=8
Frequency=2728069 Hz, Resolution=366.5596 ns, Timer=TSC
  [Host]     : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit LegacyJIT-v4.7.2650.0 DEBUG  [AttachedDebugger]
  Job-OOWXZL : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2650.0

RemoveOutliers=True  LaunchCount=1  TargetCount=5  
UnrollFactor=50  WarmupCount=0  

```
 |    ORM |                  Method | Return |     Mean |     Error |    StdDev | Rank |   Gen 0 |  Gen 1 | Allocated |
 |------- |------------------------ |------- |---------:|----------:|----------:|-----:|--------:|-------:|----------:|
 | RepoDb | 'Query<T> (unbuffered)' |   Post | 1.497 ms | 0.1472 ms | 0.0382 ms |    1 | 22.5000 | 7.5000 |  70.29 KB |
 | RepoDb |  QueryFirstOrDefault<T> |   Post | 1.549 ms | 0.1789 ms | 0.0465 ms |    1 | 22.5000 | 7.5000 |  70.29 KB |
