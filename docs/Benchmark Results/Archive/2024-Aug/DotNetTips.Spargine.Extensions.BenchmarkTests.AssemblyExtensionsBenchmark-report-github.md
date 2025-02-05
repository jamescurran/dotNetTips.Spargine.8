```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4651/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.302
  [Host]     : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  Job-ZSORKR : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Reflection  

```
| Method           | Mean       | Error    | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Exceptions | Completed Work Items | Lock Contentions | Code Size | Allocated |
|----------------- |-----------:|---------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|-----------:|---------------------:|-----------------:|----------:|----------:|
| **GetAllInterfaces** | **2,141.0 ns** | **10.46 ns** | **9.79 ns** | **2.53 ns** | **2,124.1 ns** | **2,134.5 ns** | **2,141.9 ns** | **2,147.4 ns** | **2,156.4 ns** |   **467,081.4** |      **10.464 ns** |      **15.00** |    **1.742** |  **2.000** |  **-0.1724** |    **3** | *****            | **No**       | **0.0038** |          **-** |                    **-** |                **-** |     **746 B** |     **592 B** |
| **GetAllTypes**      | **2,143.0 ns** |  **9.34 ns** | **8.74 ns** | **2.26 ns** | **2,129.2 ns** | **2,137.2 ns** | **2,139.8 ns** | **2,148.7 ns** | **2,163.3 ns** |   **466,640.0** |       **9.340 ns** |      **15.00** |    **2.662** |  **2.000** |   **0.6238** |    **3** | *****            | **No**       | **0.0153** |          **-** |                    **-** |                **-** |     **867 B** |    **1568 B** |
| **GetInstances**     |   **613.2 ns** |  **5.43 ns** | **5.08 ns** | **1.31 ns** |   **606.7 ns** |   **609.6 ns** |   **610.9 ns** |   **617.8 ns** |   **621.1 ns** | **1,630,749.1** |       **5.434 ns** |      **15.00** |    **1.465** |  **2.000** |   **0.3519** |    **1** | *****            | **No**       |      **-** |          **-** |                    **-** |                **-** |     **137 B** |      **56 B** |
| **GetTypes**         | **1,969.0 ns** |  **7.66 ns** | **7.17 ns** | **1.85 ns** | **1,955.6 ns** | **1,964.1 ns** | **1,968.3 ns** | **1,972.6 ns** | **1,982.1 ns** |   **507,864.5** |       **7.664 ns** |      **15.00** |    **2.162** |  **2.000** |   **0.1693** |    **2** | *****            | **No**       | **0.0038** |          **-** |                    **-** |                **-** |     **618 B** |     **600 B** |
