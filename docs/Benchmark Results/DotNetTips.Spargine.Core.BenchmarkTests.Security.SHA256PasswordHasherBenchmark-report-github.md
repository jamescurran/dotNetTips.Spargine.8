```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5371/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  Job-FLPXNP : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests.Security  

```
| Method                      | Categories         | Mean        | Error     | StdDev    | StdErr   | Min         | Q1          | Median      | Q3          | Max         | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Code Size | Allocated |
|---------------------------- |------------------- |------------:|----------:|----------:|---------:|------------:|------------:|------------:|------------:|------------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|-------:|----------:|----------:|
| **&#39;HashPassword: LONG STRING&#39;** | **Encryption,**NEW**** | **8,316.16 ns** | **21.806 ns** | **18.209 ns** | **5.050 ns** | **8,284.77 ns** | **8,306.51 ns** | **8,314.77 ns** | **8,324.20 ns** | **8,357.10 ns** |    **120,247.8** |       **3.975 ns** |      **13.00** |    **2.877** |  **2.000** |   **0.3907** |    **4** | *****            | **No**       |          **-** |                    **-** |                **-** | **0.0153** |     **371 B** |    **2320 B** |
| **FixedTimeEquals**             | **Encryption**         |    **48.46 ns** |  **0.254 ns** |  **0.237 ns** | **0.061 ns** |    **48.15 ns** |    **48.28 ns** |    **48.37 ns** |    **48.63 ns** |    **48.85 ns** | **20,634,614.7** |       **7.469 ns** |      **15.00** |    **1.466** |  **2.000** |   **0.3870** |    **1** | *****            | **No**       |          **-** |                    **-** |                **-** | **0.0007** |     **604 B** |      **64 B** |
| **HashPassword**                | **Encryption**         |   **709.52 ns** |  **3.627 ns** |  **3.393 ns** | **0.876 ns** |   **704.73 ns** |   **706.42 ns** |   **710.70 ns** |   **712.33 ns** |   **714.01 ns** |  **1,409,402.1** |       **7.062 ns** |      **15.00** |    **1.149** |  **2.000** |  **-0.0657** |    **2** | *****            | **No**       |          **-** |                    **-** |                **-** | **0.0038** |     **378 B** |     **400 B** |
| **VerifyHashedPassword**        | **Encryption**         | **1,912.55 ns** |  **8.410 ns** |  **7.456 ns** | **1.993 ns** | **1,900.99 ns** | **1,908.04 ns** | **1,911.10 ns** | **1,916.10 ns** | **1,930.13 ns** |    **522,861.1** |       **6.004 ns** |      **14.00** |    **2.914** |  **2.000** |   **0.7087** |    **3** | *****            | **No**       |          **-** |                    **-** |                **-** | **0.0076** |   **3,021 B** |    **1016 B** |
