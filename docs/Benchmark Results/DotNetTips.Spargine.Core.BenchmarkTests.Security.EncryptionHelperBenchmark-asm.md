## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.AesDecrypt()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+118]
       mov       rdx,[rbx+128]
       mov       r8,[rbx+120]
       call      qword ptr [7FFE5C954B70]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E8
       lea       rbp,[rsp+120]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0F0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-50],xmm4
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0F8],rsp
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rdi,rdi
       je        short M01_L01
       xor       ecx,ecx
       cmp       dword ptr [rdi+8],0
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       cmp       dword ptr [rdi+8],0
       jne       short M01_L02
       jmp       short M01_L02
M01_L01:
       xor       ecx,ecx
M01_L02:
       test      ecx,ecx
       je        near ptr M01_L67
       cmp       dword ptr [rdi+8],0
       je        short M01_L06
       movzx     ecx,word ptr [rdi+0C]
       cmp       ecx,100
       jae       short M01_L03
       mov       rax,7FFE78C52E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L69
       jmp       short M01_L04
M01_L03:
       call      qword ptr [7FFE5CE36070]
       test      eax,eax
       jne       near ptr M01_L69
M01_L04:
       mov       ecx,[rdi+8]
       dec       ecx
       cmp       ecx,[rdi+8]
       jae       near ptr M01_L72
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFE78C52E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L69
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE5CE36070]
       test      eax,eax
       jne       near ptr M01_L69
M01_L06:
       test      rbx,rbx
       je        near ptr M01_L70
M01_L07:
       test      rsi,rsi
       je        near ptr M01_L71
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       rax,2B22C8B7178
       mov       [rcx+10],rax
       xor       eax,eax
       mov       [rcx+24],eax
       mov       byte ptr [rcx+28],1
       mov       byte ptr [rcx+29],1
       mov       byte ptr [rcx+2A],1
       mov       byte ptr [rcx+2B],1
       mov       [rbp-68],rcx
       mov       rcx,offset MT_System.Security.Cryptography.AesCng
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+28],1
       mov       dword ptr [r14+2C],2
       mov       rcx,2719AC09FF0
       mov       r15,[rcx]
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r13,rax
       mov       rcx,[r13]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L08
       mov       r8d,[r13+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L08:
       mov       r8,rdx
       lea       rdx,[r15+8]
       lea       rcx,[r13+8]
       mov       rax,[r13]
       test      dword ptr [rax],1000000
       je        short M01_L10
       cmp       r8,4000
       ja        short M01_L09
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L11
M01_L09:
       call      qword ptr [7FFE5C5A5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L11
M01_L10:
       call      qword ptr [7FFE5C5A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       rdx,r13
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2719AC09FF8
       mov       r15,[rcx]
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r13,rax
       mov       rcx,[r13]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L12
       mov       r8d,[r13+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L12:
       mov       r8,rdx
       lea       rdx,[r15+8]
       lea       rcx,[r13+8]
       mov       rax,[r13]
       test      dword ptr [rax],1000000
       je        short M01_L14
       cmp       r8,4000
       ja        short M01_L13
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L13:
       call      qword ptr [7FFE5C5A5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L14:
       call      qword ptr [7FFE5C5A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L15:
       mov       rdx,r13
       lea       rcx,[r14+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r14+30],80
       mov       dword ptr [r14+34],8
       mov       dword ptr [r14+38],100
       mov       dword ptr [r14+28],1
       mov       rcx,r14
       lea       rcx,[rcx+40]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+48],rcx
       mov       [r14+50],rcx
       mov       [r14+58],ecx
       mov       rcx,r14
       mov       [rbp-70],rcx
       lea       r14,[rcx+40]
       mov       rcx,[r14]
       mov       r11,7FFE5C3B0B68
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[r14]
       mov       r11,7FFE5C3B0B70
       call      qword ptr [r11]
       mov       r13d,eax
       mov       rcx,[r14]
       mov       r11,7FFE5C3B0B78
       call      qword ptr [r11]
       mov       r12d,eax
       cmp       r13d,4
       je        near ptr M01_L18
M01_L16:
       lea       rax,[rbx+10]
       mov       ebx,[rbx+8]
       mov       [rbp-0C8],rax
       movsxd    rdx,ebx
       shl       rdx,3
       mov       [rbp-40],rdx
       cmp       rdx,7FFFFFFF
       jg        near ptr M01_L31
       mov       rcx,[r14]
       mov       r8,offset MT_System.Security.Cryptography.AesCng
       cmp       [rcx],r8
       jne       near ptr M01_L33
       mov       r8,[rcx+20]
       mov       [rbp-88],r8
       cmp       [r8],r8b
       mov       rcx,r8
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r10,rax
       mov       [rbp-90],r10
       mov       rcx,[r10]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L17
       mov       r8d,[r10+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L17:
       mov       r8,rdx
       mov       rdx,[rbp-88]
       add       rdx,8
       lea       rcx,[r10+8]
       mov       rax,[r10]
       test      dword ptr [rax],1000000
       je        near ptr M01_L36
       cmp       r8,4000
       ja        near ptr M01_L35
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L37
M01_L18:
       cmp       qword ptr [r14+8],0
       jne       near ptr M01_L19
       mov       rcx,[r14]
       mov       edx,r12d
       mov       r11,7FFE5C3B0B88
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L16
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CD551A0]
       mov       rsi,rax
       mov       [rbx+8],r12d
       mov       rcx,offset MT_System.Security.Cryptography.CipherMode
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],4
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r8,r12
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5CD54B88]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE5C4FCED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       cmp       r12d,8
       je        near ptr M01_L16
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CD551A0]
       mov       rdi,rax
       mov       [rsi+8],r12d
       mov       rcx,offset MT_System.Security.Cryptography.CipherMode
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],4
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r8,r14
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE5CD54B88]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C4FCED0]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L20:
       call      qword ptr [7FFE5C6EE9D0]
       int       3
M01_L21:
       mov       rbx,2B22C8B7178
       jmp       near ptr M01_L60
M01_L22:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L59
M01_L23:
       call      qword ptr [7FFE5C6EE9E8]
       int       3
M01_L24:
       mov       ecx,1D75
       mov       rdx,7FFE5C3A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5C7166E8]
       int       3
M01_L25:
       xor       esi,esi
       jmp       near ptr M01_L49
M01_L26:
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE5CD557D0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE5C4FCED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE5CD55608]
       mov       r14,rax
       mov       ecx,4503
       mov       rdx,7FFE5C9A2308
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FFE5C4FF750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rdx,rbx
       mov       r11,7FFE5C3B0BA0
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M01_L44
M01_L29:
       call      qword ptr [7FFE5CD55638]
       mov       rsi,rax
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[r14]
       mov       r11,7FFE5C3B0BA8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5CD54B70]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE5C4FCED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       rbx,2B22C8B7178
       jmp       near ptr M01_L42
M01_L31:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CD55650]
       mov       rdi,rax
       mov       ecx,44F5
       mov       rdx,7FFE5C9A2308
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE5C4FF750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L32:
       mov       edx,[r11+8]
       cmp       edx,eax
       jne       short M01_L40
       jmp       short M01_L41
M01_L33:
       mov       r11,7FFE5C3B0B90
       call      qword ptr [r11]
       mov       r8,rax
       jmp       short M01_L38
M01_L34:
       xor       edx,edx
       jmp       near ptr M01_L51
M01_L35:
       call      qword ptr [7FFE5C5A5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L37
M01_L36:
       call      qword ptr [7FFE5C5A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L37:
       mov       r8,[rbp-90]
M01_L38:
       xor       ecx,ecx
       mov       r10d,[r8+8]
       test      r10d,r10d
       jle       near ptr M01_L31
M01_L39:
       mov       r9,[rbp-40]
       mov       eax,r9d
       mov       edx,ecx
       mov       r11,[r8+rdx*8+10]
       mov       edx,[r11+10]
       test      edx,edx
       je        short M01_L32
       mov       r9d,[r11+8]
       cmp       eax,r9d
       jl        short M01_L40
       cmp       eax,[r11+0C]
       jg        short M01_L40
       sub       eax,r9d
       mov       r9d,edx
       cdq
       idiv      r9d
       test      edx,edx
       je        short M01_L41
M01_L40:
       inc       ecx
       cmp       r10d,ecx
       jg        short M01_L39
       jmp       near ptr M01_L31
M01_L41:
       test      ebx,ebx
       je        near ptr M01_L30
       mov       edx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-98],rax
       lea       rcx,[rax+10]
       mov       r8d,ebx
       mov       rdx,[rbp-0C8]
       call      qword ptr [7FFE5C5A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rbp-98]
M01_L42:
       mov       rcx,[r14]
       mov       rdx,offset MT_System.Security.Cryptography.AesCng
       cmp       [rcx],rdx
       je        short M01_L43
       mov       rdx,rbx
       mov       r11,7FFE5C3B0B98
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L29
M01_L43:
       mov       rcx,[r14]
       mov       r11,offset MT_System.Security.Cryptography.AesCng
       cmp       [rcx],r11
       jne       near ptr M01_L28
M01_L44:
       mov       eax,[rsi+8]
       mov       [rbp-0E4],eax
       mov       rcx,[r14]
       mov       r11,7FFE5C3B0B80
       call      qword ptr [r11]
       add       eax,7
       mov       ecx,eax
       sar       ecx,1F
       and       ecx,7
       add       ecx,eax
       sar       ecx,3
       cmp       [rbp-0E4],ecx
       jne       near ptr M01_L27
       xor       eax,eax
       cmp       r13d,2
       cmove     rsi,rax
       test      rsi,rsi
       je        near ptr M01_L25
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       [rbp-0A0],rax
       mov       rcx,[rax]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L45
       mov       r8d,[rax+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L45:
       mov       r8,rdx
       lea       rdx,[rsi+8]
       lea       rcx,[rax+8]
       mov       r10,[rax]
       test      dword ptr [r10],1000000
       je        short M01_L47
       cmp       r8,4000
       ja        short M01_L46
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L48
M01_L46:
       call      qword ptr [7FFE5C5A5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L48
M01_L47:
       call      qword ptr [7FFE5C5A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L48:
       mov       rsi,[rbp-0A0]
M01_L49:
       mov       rcx,[r14]
       mov       r11,7FFE5C3B0BB0
       call      qword ptr [r11]
       add       eax,7
       mov       r10d,eax
       sar       r10d,1F
       and       r10d,7
       add       eax,r10d
       sar       eax,3
       mov       [rbp-44],eax
       mov       rcx,[r14]
       mov       r8d,r12d
       mov       edx,r13d
       mov       r11,7FFE5C3B0BB8
       call      qword ptr [r11]
       mov       [rbp-0A8],rax
       mov       rcx,[r14]
       mov       r8d,r12d
       mov       edx,r13d
       mov       r11,7FFE5C3B0BC0
       call      qword ptr [r11]
       mov       r12d,eax
       test      rbx,rbx
       je        near ptr M01_L56
       lea       r14,[rbx+10]
       mov       ebx,[rbx+8]
M01_L50:
       mov       rcx,offset MT_System.Security.Cryptography.BasicSymmetricCipherBCrypt
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0B0],rax
       cmp       r13d,2
       je        near ptr M01_L34
       test      rsi,rsi
       je        near ptr M01_L26
       mov       rdx,rsi
M01_L51:
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0B0]
       mov       r13d,[rbp-44]
       mov       [rsi+10],r13d
       test      r12d,r12d
       jg        near ptr M01_L61
       mov       ecx,r13d
M01_L52:
       mov       [rsi+14],ecx
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M01_L55
       lea       rax,[rcx+10]
       mov       [rbp-0D0],rax
       mov       edx,[rcx+8]
       mov       [rbp-48],edx
M01_L53:
       mov       rcx,offset MT_System.Security.Cryptography.BasicSymmetricCipherLiteBCrypt
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0B8],rax
       mov       r8,[rbp-0D0]
       mov       [rbp-0D8],r8
       mov       r10d,[rbp-48]
       mov       [rbp-4C],r10d
       test      r10d,r10d
       je        short M01_L54
       movsxd    rdx,r10d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdx,rax
       mov       [rbp-0C0],rdx
       lea       rcx,[rdx+10]
       mov       r8d,[rbp-4C]
       mov       rdx,[rbp-0D8]
       call      qword ptr [7FFE5C5A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,[rbp-0C0]
       mov       rax,[rbp-0B8]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
M01_L54:
       mov       rax,[rbp-0B8]
       mov       [rax+18],r13d
       mov       [rax+1C],r12d
       mov       byte ptr [rax+20],1
       lea       rcx,[rax+10]
       mov       [rbp-0F0],rcx
       mov       r13,[rbp-0A8]
       mov       [rbp-60],r14
       mov       [rbp-58],ebx
       mov       rcx,r13
       lea       rdx,[rbp-60]
       call      qword ptr [7FFE5CC5FA38]; Interop+BCrypt.BCryptImportKey(Internal.NativeCrypto.SafeAlgorithmHandle, System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rbp-0F0]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Security.Cryptography.UniversalCryptoEncryptor
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],r15d
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L62
M01_L55:
       xor       eax,eax
       xor       edx,edx
       mov       [rbp-0D0],rax
       mov       [rbp-48],edx
       jmp       near ptr M01_L53
M01_L56:
       xor       r14d,r14d
       xor       ebx,ebx
       jmp       near ptr M01_L50
M01_L57:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
M01_L58:
       mov       rdx,[rbp-68]
       mov       rcx,[rdx+10]
       mov       r8d,[rdx+18]
       test      rcx,rcx
       je        near ptr M01_L20
       mov       eax,r8d
       mov       r10d,r15d
       add       rax,r10
       mov       r10d,[rcx+8]
       cmp       rax,r10
       ja        near ptr M01_L20
       cmp       [rcx],cl
       lea       rcx,[rcx+r8+10]
       mov       [rbp-0E0],rcx
       test      rbx,rbx
       je        near ptr M01_L22
       lea       rsi,[rbx+10]
       mov       edi,[rbx+8]
M01_L59:
       cmp       r15d,edi
       ja        near ptr M01_L23
       mov       r8d,r15d
       mov       rcx,rsi
       mov       rdx,[rbp-0E0]
       call      qword ptr [7FFE5C5A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L60:
       test      rbx,rbx
       je        near ptr M01_L24
       lea       rcx,[rbx+10]
       mov       edx,[rbx+8]
       mov       [rbp-60],rcx
       mov       [rbp-58],edx
       lea       rcx,[rbp-60]
       xor       edx,edx
       call      qword ptr [7FFE5C7F4648]; System.Convert.ToBase64String(System.ReadOnlySpan`1<Byte>, System.Base64FormattingOptions)
       mov       rsi,rax
       jmp       near ptr M01_L64
M01_L61:
       mov       ecx,r12d
       jmp       near ptr M01_L52
M01_L62:
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,r15
       mov       rdx,[rbp-68]
       mov       r8,rbx
       mov       r9d,1
       call      qword ptr [7FFE5CD54018]; System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp-78],r15
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,2719AC013C0
       mov       r8,[r8]
       mov       rcx,rsi
       mov       rdx,r15
       mov       r9d,400
       call      qword ptr [7FFE5C66DB78]; System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       rcx,rsi
       mov       [rbp-80],rcx
       mov       rdx,rdi
       call      qword ptr [7FFE5C680658]; System.IO.StreamWriter.Write(System.String)
       nop
       mov       rcx,[rbp-80]
       mov       edx,1
       call      qword ptr [7FFE5C6805C0]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-80]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       rcx,r15
       mov       edx,1
       call      qword ptr [7FFE5CD38DD8]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,r15
       call      System.GC._SuppressFinalize(System.Object)
       mov       rdx,[rbp-68]
       mov       r15d,[rdx+20]
       sub       r15d,[rdx+18]
       je        near ptr M01_L21
       cmp       r15d,800
       jl        near ptr M01_L57
       mov       edx,r15d
       mov       rcx,offset MT_System.Byte[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rbx,rax
       jmp       near ptr M01_L58
M01_L63:
       mov       rcx,[rcx+8]
       call      qword ptr [7FFE5C4474B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+8],rcx
       mov       rcx,rax
       jmp       short M01_L65
M01_L64:
       mov       rcx,[rbp-70]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L63
M01_L65:
       cmp       qword ptr [rcx+10],0
       je        short M01_L66
       mov       rcx,[rcx+10]
       call      qword ptr [7FFE5C4474B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+10],rcx
M01_L66:
       mov       rax,[rbp-70]
       mov       rcx,rax
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       rdx,[rbp-68]
       mov       byte ptr [rdx+2B],0
       mov       byte ptr [rdx+29],0
       mov       byte ptr [rdx+28],0
       xor       ecx,ecx
       mov       [rdx+30],rcx
       mov       rcx,rdx
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       rax,rsi
       add       rsp,0E8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L67:
       call      qword ptr [7FFE5CA04570]
       mov       r14,rax
       test      r14,r14
       jne       short M01_L68
       call      qword ptr [7FFE5CA042B8]
       mov       r14,rax
M01_L68:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       rdx,2B22C8C3D90
       mov       r8,r14
       call      qword ptr [7FFE5C716670]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M01_L69:
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [7FFE5C4F73F0]
       mov       rdi,rax
       test      rbx,rbx
       jne       near ptr M01_L07
M01_L70:
       call      qword ptr [7FFE5CA044C8]
       mov       ecx,1AF6
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,146C
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA042B8]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rbx
       call      qword ptr [7FFE5C716670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L71:
       call      qword ptr [7FFE5CA044C8]
       mov       ecx,1AFE
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CA042B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L72:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       mov       rcx,[rbp-80]
       mov       edx,1
       call      qword ptr [7FFE5C6805C0]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-80]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       mov       rcx,[rbp-78]
       mov       edx,1
       call      qword ptr [7FFE5CD38DD8]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,[rbp-78]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       mov       rax,[rbp-70]
       cmp       qword ptr [rax+8],0
       je        short M01_L73
       mov       rcx,[rax+8]
       call      qword ptr [7FFE5C4474B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+8],rcx
M01_L73:
       cmp       qword ptr [rax+10],0
       je        short M01_L74
       mov       rcx,[rax+10]
       call      qword ptr [7FFE5C4474B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+10],rcx
M01_L74:
       mov       rcx,rax
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       mov       rdx,[rbp-68]
       mov       byte ptr [rdx+2B],0
       mov       byte ptr [rdx+29],0
       mov       byte ptr [rdx+28],0
       xor       ecx,ecx
       mov       [rdx+30],rcx
       mov       rcx,rdx
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       mov       rbx,rdx
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CA04210]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFE5C716730]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 3854
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.AesEncrypt()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,[rbx+128]
       mov       r8,[rbx+120]
       call      qword ptr [7FFE5C964B70]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E8
       lea       rbp,[rsp+120]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0F0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-50],xmm4
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0F8],rsp
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rdi,rdi
       je        short M01_L01
       xor       ecx,ecx
       cmp       dword ptr [rdi+8],0
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       cmp       dword ptr [rdi+8],0
       jne       short M01_L02
       jmp       short M01_L02
M01_L01:
       xor       ecx,ecx
M01_L02:
       test      ecx,ecx
       je        near ptr M01_L67
       cmp       dword ptr [rdi+8],0
       je        short M01_L06
       movzx     ecx,word ptr [rdi+0C]
       cmp       ecx,100
       jae       short M01_L03
       mov       rax,7FFE78C52E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L69
       jmp       short M01_L04
M01_L03:
       call      qword ptr [7FFE5CE0E898]
       test      eax,eax
       jne       near ptr M01_L69
M01_L04:
       mov       ecx,[rdi+8]
       dec       ecx
       cmp       ecx,[rdi+8]
       jae       near ptr M01_L72
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFE78C52E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L69
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE5CE0E898]
       test      eax,eax
       jne       near ptr M01_L69
M01_L06:
       test      rbx,rbx
       je        near ptr M01_L70
M01_L07:
       test      rsi,rsi
       je        near ptr M01_L71
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       rax,1E1E3B77178
       mov       [rcx+10],rax
       xor       eax,eax
       mov       [rcx+24],eax
       mov       byte ptr [rcx+28],1
       mov       byte ptr [rcx+29],1
       mov       byte ptr [rcx+2A],1
       mov       byte ptr [rcx+2B],1
       mov       [rbp-68],rcx
       mov       rcx,offset MT_System.Security.Cryptography.AesCng
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+28],1
       mov       dword ptr [r14+2C],2
       mov       rcx,1A151C07FF8
       mov       r15,[rcx]
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r13,rax
       mov       rcx,[r13]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L08
       mov       r8d,[r13+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L08:
       mov       r8,rdx
       lea       rdx,[r15+8]
       lea       rcx,[r13+8]
       mov       rax,[r13]
       test      dword ptr [rax],1000000
       je        short M01_L10
       cmp       r8,4000
       ja        short M01_L09
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L11
M01_L09:
       call      qword ptr [7FFE5C5B5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L11
M01_L10:
       call      qword ptr [7FFE5C5B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       rdx,r13
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1A151C08000
       mov       r15,[rcx]
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r13,rax
       mov       rcx,[r13]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L12
       mov       r8d,[r13+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L12:
       mov       r8,rdx
       lea       rdx,[r15+8]
       lea       rcx,[r13+8]
       mov       rax,[r13]
       test      dword ptr [rax],1000000
       je        short M01_L14
       cmp       r8,4000
       ja        short M01_L13
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L13:
       call      qword ptr [7FFE5C5B5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L14:
       call      qword ptr [7FFE5C5B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L15:
       mov       rdx,r13
       lea       rcx,[r14+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r14+30],80
       mov       dword ptr [r14+34],8
       mov       dword ptr [r14+38],100
       mov       dword ptr [r14+28],1
       mov       rcx,r14
       lea       rcx,[rcx+40]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+48],rcx
       mov       [r14+50],rcx
       mov       [r14+58],ecx
       mov       rcx,r14
       mov       [rbp-70],rcx
       lea       r14,[rcx+40]
       mov       rcx,[r14]
       mov       r11,7FFE5C3C0B18
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[r14]
       mov       r11,7FFE5C3C0B20
       call      qword ptr [r11]
       mov       r13d,eax
       mov       rcx,[r14]
       mov       r11,7FFE5C3C0B28
       call      qword ptr [r11]
       mov       r12d,eax
       cmp       r13d,4
       je        near ptr M01_L18
M01_L16:
       lea       rax,[rbx+10]
       mov       ebx,[rbx+8]
       mov       [rbp-0C8],rax
       movsxd    rdx,ebx
       shl       rdx,3
       mov       [rbp-40],rdx
       cmp       rdx,7FFFFFFF
       jg        near ptr M01_L31
       mov       rcx,[r14]
       mov       r8,offset MT_System.Security.Cryptography.AesCng
       cmp       [rcx],r8
       jne       near ptr M01_L33
       mov       r8,[rcx+20]
       mov       [rbp-88],r8
       cmp       [r8],r8b
       mov       rcx,r8
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r10,rax
       mov       [rbp-90],r10
       mov       rcx,[r10]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L17
       mov       r8d,[r10+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L17:
       mov       r8,rdx
       mov       rdx,[rbp-88]
       add       rdx,8
       lea       rcx,[r10+8]
       mov       rax,[r10]
       test      dword ptr [rax],1000000
       je        near ptr M01_L36
       cmp       r8,4000
       ja        near ptr M01_L35
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L37
M01_L18:
       cmp       qword ptr [r14+8],0
       jne       near ptr M01_L19
       mov       rcx,[r14]
       mov       edx,r12d
       mov       r11,7FFE5C3C0B38
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L16
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CD651A0]
       mov       rsi,rax
       mov       [rbx+8],r12d
       mov       rcx,offset MT_System.Security.Cryptography.CipherMode
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],4
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r8,r12
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5CD64B88]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE5C50CED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       cmp       r12d,8
       je        near ptr M01_L16
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CD651A0]
       mov       rdi,rax
       mov       [rsi+8],r12d
       mov       rcx,offset MT_System.Security.Cryptography.CipherMode
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],4
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r8,r14
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE5CD64B88]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C50CED0]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L20:
       call      qword ptr [7FFE5C6FE9D0]
       int       3
M01_L21:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L60
M01_L22:
       call      qword ptr [7FFE5C6FE9E8]
       int       3
M01_L23:
       mov       ecx,1D75
       mov       rdx,7FFE5C3B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE5C7266E8]
       int       3
M01_L24:
       mov       rbx,1E1E3B77178
       jmp       near ptr M01_L61
M01_L25:
       xor       esi,esi
       jmp       near ptr M01_L49
M01_L26:
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE5CD657D0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE5C50CED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE5CD65608]
       mov       r14,rax
       mov       ecx,4503
       mov       rdx,7FFE5C9B2308
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FFE5C50F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rdx,rbx
       mov       r11,7FFE5C3C0B50
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M01_L44
M01_L29:
       call      qword ptr [7FFE5CD65638]
       mov       rsi,rax
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[r14]
       mov       r11,7FFE5C3C0B58
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5CD64B70]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE5C50CED0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       rbx,1E1E3B77178
       jmp       near ptr M01_L42
M01_L31:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CD65650]
       mov       rdi,rax
       mov       ecx,44F5
       mov       rdx,7FFE5C9B2308
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE5C50F750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L32:
       mov       edx,[r11+8]
       cmp       edx,eax
       jne       short M01_L40
       jmp       short M01_L41
M01_L33:
       mov       r11,7FFE5C3C0B40
       call      qword ptr [r11]
       mov       r8,rax
       jmp       short M01_L38
M01_L34:
       xor       edx,edx
       jmp       near ptr M01_L51
M01_L35:
       call      qword ptr [7FFE5C5B5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L37
M01_L36:
       call      qword ptr [7FFE5C5B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L37:
       mov       r8,[rbp-90]
M01_L38:
       xor       ecx,ecx
       mov       r10d,[r8+8]
       test      r10d,r10d
       jle       near ptr M01_L31
M01_L39:
       mov       r9,[rbp-40]
       mov       eax,r9d
       mov       edx,ecx
       mov       r11,[r8+rdx*8+10]
       mov       edx,[r11+10]
       test      edx,edx
       je        short M01_L32
       mov       r9d,[r11+8]
       cmp       eax,r9d
       jl        short M01_L40
       cmp       eax,[r11+0C]
       jg        short M01_L40
       sub       eax,r9d
       mov       r9d,edx
       cdq
       idiv      r9d
       test      edx,edx
       je        short M01_L41
M01_L40:
       inc       ecx
       cmp       r10d,ecx
       jg        short M01_L39
       jmp       near ptr M01_L31
M01_L41:
       test      ebx,ebx
       je        near ptr M01_L30
       mov       edx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-98],rax
       lea       rcx,[rax+10]
       mov       r8d,ebx
       mov       rdx,[rbp-0C8]
       call      qword ptr [7FFE5C5B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rbp-98]
M01_L42:
       mov       rcx,[r14]
       mov       rdx,offset MT_System.Security.Cryptography.AesCng
       cmp       [rcx],rdx
       je        short M01_L43
       mov       rdx,rbx
       mov       r11,7FFE5C3C0B48
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L29
M01_L43:
       mov       rcx,[r14]
       mov       r11,offset MT_System.Security.Cryptography.AesCng
       cmp       [rcx],r11
       jne       near ptr M01_L28
M01_L44:
       mov       eax,[rsi+8]
       mov       [rbp-0E4],eax
       mov       rcx,[r14]
       mov       r11,7FFE5C3C0B30
       call      qword ptr [r11]
       add       eax,7
       mov       ecx,eax
       sar       ecx,1F
       and       ecx,7
       add       ecx,eax
       sar       ecx,3
       cmp       [rbp-0E4],ecx
       jne       near ptr M01_L27
       xor       eax,eax
       cmp       r13d,2
       cmove     rsi,rax
       test      rsi,rsi
       je        near ptr M01_L25
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       [rbp-0A0],rax
       mov       rcx,[rax]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L45
       mov       r8d,[rax+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L45:
       mov       r8,rdx
       lea       rdx,[rsi+8]
       lea       rcx,[rax+8]
       mov       r10,[rax]
       test      dword ptr [r10],1000000
       je        short M01_L47
       cmp       r8,4000
       ja        short M01_L46
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L48
M01_L46:
       call      qword ptr [7FFE5C5B5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L48
M01_L47:
       call      qword ptr [7FFE5C5B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L48:
       mov       rsi,[rbp-0A0]
M01_L49:
       mov       rcx,[r14]
       mov       r11,7FFE5C3C0B60
       call      qword ptr [r11]
       add       eax,7
       mov       r10d,eax
       sar       r10d,1F
       and       r10d,7
       add       eax,r10d
       sar       eax,3
       mov       [rbp-44],eax
       mov       rcx,[r14]
       mov       r8d,r12d
       mov       edx,r13d
       mov       r11,7FFE5C3C0B68
       call      qword ptr [r11]
       mov       [rbp-0A8],rax
       mov       rcx,[r14]
       mov       r8d,r12d
       mov       edx,r13d
       mov       r11,7FFE5C3C0B70
       call      qword ptr [r11]
       mov       r12d,eax
       test      rbx,rbx
       je        near ptr M01_L56
       lea       r14,[rbx+10]
       mov       ebx,[rbx+8]
M01_L50:
       mov       rcx,offset MT_System.Security.Cryptography.BasicSymmetricCipherBCrypt
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0B0],rax
       cmp       r13d,2
       je        near ptr M01_L34
       test      rsi,rsi
       je        near ptr M01_L26
       mov       rdx,rsi
M01_L51:
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0B0]
       mov       r13d,[rbp-44]
       mov       [rsi+10],r13d
       test      r12d,r12d
       jg        near ptr M01_L57
       mov       ecx,r13d
M01_L52:
       mov       [rsi+14],ecx
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M01_L55
       lea       rax,[rcx+10]
       mov       [rbp-0D0],rax
       mov       edx,[rcx+8]
       mov       [rbp-48],edx
M01_L53:
       mov       rcx,offset MT_System.Security.Cryptography.BasicSymmetricCipherLiteBCrypt
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0B8],rax
       mov       r8,[rbp-0D0]
       mov       [rbp-0D8],r8
       mov       r10d,[rbp-48]
       mov       [rbp-4C],r10d
       test      r10d,r10d
       je        short M01_L54
       movsxd    rdx,r10d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdx,rax
       mov       [rbp-0C0],rdx
       lea       rcx,[rdx+10]
       mov       r8d,[rbp-4C]
       mov       rdx,[rbp-0D8]
       call      qword ptr [7FFE5C5B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,[rbp-0C0]
       mov       rax,[rbp-0B8]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
M01_L54:
       mov       rax,[rbp-0B8]
       mov       [rax+18],r13d
       mov       [rax+1C],r12d
       mov       byte ptr [rax+20],1
       lea       rcx,[rax+10]
       mov       [rbp-0F0],rcx
       mov       r13,[rbp-0A8]
       mov       [rbp-60],r14
       mov       [rbp-58],ebx
       mov       rcx,r13
       lea       rdx,[rbp-60]
       call      qword ptr [7FFE5CC6FA38]; Interop+BCrypt.BCryptImportKey(Internal.NativeCrypto.SafeAlgorithmHandle, System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rbp-0F0]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Security.Cryptography.UniversalCryptoEncryptor
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],r15d
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L58
M01_L55:
       xor       eax,eax
       xor       edx,edx
       mov       [rbp-0D0],rax
       mov       [rbp-48],edx
       jmp       near ptr M01_L53
M01_L56:
       xor       r14d,r14d
       xor       ebx,ebx
       jmp       near ptr M01_L50
M01_L57:
       mov       ecx,r12d
       jmp       near ptr M01_L52
M01_L58:
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,r15
       mov       rdx,[rbp-68]
       mov       r8,rbx
       mov       r9d,1
       call      qword ptr [7FFE5CD64018]; System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp-78],r15
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,1A155C013C0
       mov       r8,[r8]
       mov       rcx,rsi
       mov       rdx,r15
       mov       r9d,400
       call      qword ptr [7FFE5C67DB78]; System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       rcx,rsi
       mov       [rbp-80],rcx
       mov       rdx,rdi
       call      qword ptr [7FFE5C690658]; System.IO.StreamWriter.Write(System.String)
       nop
       mov       rcx,[rbp-80]
       mov       edx,1
       call      qword ptr [7FFE5C6905C0]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-80]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       rcx,r15
       mov       edx,1
       call      qword ptr [7FFE5CD49068]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,r15
       call      System.GC._SuppressFinalize(System.Object)
       mov       rdx,[rbp-68]
       mov       r15d,[rdx+20]
       sub       r15d,[rdx+18]
       je        near ptr M01_L24
       cmp       r15d,800
       jl        near ptr M01_L62
       mov       edx,r15d
       mov       rcx,offset MT_System.Byte[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rbx,rax
M01_L59:
       mov       rdx,[rbp-68]
       mov       rcx,[rdx+10]
       mov       r8d,[rdx+18]
       test      rcx,rcx
       je        near ptr M01_L20
       mov       eax,r8d
       mov       r10d,r15d
       add       rax,r10
       mov       r10d,[rcx+8]
       cmp       rax,r10
       ja        near ptr M01_L20
       cmp       [rcx],cl
       lea       rcx,[rcx+r8+10]
       mov       [rbp-0E0],rcx
       test      rbx,rbx
       je        near ptr M01_L21
       lea       rsi,[rbx+10]
       mov       edi,[rbx+8]
M01_L60:
       cmp       r15d,edi
       ja        near ptr M01_L22
       mov       r8d,r15d
       mov       rcx,rsi
       mov       rdx,[rbp-0E0]
       call      qword ptr [7FFE5C5B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L61:
       test      rbx,rbx
       je        near ptr M01_L23
       lea       rcx,[rbx+10]
       mov       edx,[rbx+8]
       mov       [rbp-60],rcx
       mov       [rbp-58],edx
       lea       rcx,[rbp-60]
       xor       edx,edx
       call      qword ptr [7FFE5C804648]; System.Convert.ToBase64String(System.ReadOnlySpan`1<Byte>, System.Base64FormattingOptions)
       mov       rsi,rax
       jmp       short M01_L64
M01_L62:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       jmp       near ptr M01_L59
M01_L63:
       mov       rcx,[rcx+8]
       call      qword ptr [7FFE5C4574B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+8],rcx
       mov       rcx,rax
       jmp       short M01_L65
M01_L64:
       mov       rcx,[rbp-70]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L63
M01_L65:
       cmp       qword ptr [rcx+10],0
       je        short M01_L66
       mov       rcx,[rcx+10]
       call      qword ptr [7FFE5C4574B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+10],rcx
       mov       rcx,rax
M01_L66:
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       rdx,[rbp-68]
       mov       byte ptr [rdx+2B],0
       mov       byte ptr [rdx+29],0
       mov       byte ptr [rdx+28],0
       xor       ecx,ecx
       mov       [rdx+30],rcx
       mov       rcx,rdx
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       rax,rsi
       add       rsp,0E8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L67:
       call      qword ptr [7FFE5CA14570]
       mov       r14,rax
       test      r14,r14
       jne       short M01_L68
       call      qword ptr [7FFE5CA142B8]
       mov       r14,rax
M01_L68:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       rdx,1E1E3B83D90
       mov       r8,r14
       call      qword ptr [7FFE5C726670]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M01_L69:
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [7FFE5C5073F0]
       mov       rdi,rax
       test      rbx,rbx
       jne       near ptr M01_L07
M01_L70:
       call      qword ptr [7FFE5CA144C8]
       mov       ecx,1AF6
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,146C
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C506B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE5C506B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA142B8]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rbx
       call      qword ptr [7FFE5C726670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L71:
       call      qword ptr [7FFE5CA144C8]
       mov       ecx,1AFE
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C506B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C506B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CA142B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L72:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       mov       rcx,[rbp-80]
       mov       edx,1
       call      qword ptr [7FFE5C6905C0]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-80]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       mov       rcx,[rbp-78]
       mov       edx,1
       call      qword ptr [7FFE5CD49068]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,[rbp-78]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       mov       rax,[rbp-70]
       cmp       qword ptr [rax+8],0
       je        short M01_L73
       mov       rcx,[rax+8]
       call      qword ptr [7FFE5C4574B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+8],rcx
M01_L73:
       cmp       qword ptr [rax+10],0
       je        short M01_L74
       mov       rcx,[rax+10]
       call      qword ptr [7FFE5C4574B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+10],rcx
M01_L74:
       mov       rcx,rax
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       mov       rdx,[rbp-68]
       mov       byte ptr [rdx+2B],0
       mov       byte ptr [rdx+29],0
       mov       byte ptr [rdx+28],0
       xor       ecx,ecx
       mov       [rdx+30],rcx
       mov       rcx,rdx
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       mov       rbx,rdx
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CA14210]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFE5C726730]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 3844
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.GenerateAesIV()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE5C9647E0]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GenerateAesIV()
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.GenerateAesIV()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-0B0],rsp
       lea       rcx,[rbp-98]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       rcx,offset MT_System.Security.Cryptography.AesImplementation
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],1
       mov       dword ptr [rsi+2C],2
       mov       rcx,2154A407FF8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r14,rax
       mov       rcx,[r14]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L00
       mov       r8d,[r14+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L00:
       mov       r8,rdx
       lea       rdx,[rdi+8]
       lea       rcx,[r14+8]
       mov       rax,[r14]
       test      dword ptr [rax],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L01:
       call      qword ptr [7FFE5C5B5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE5C5B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       lea       rcx,[rsi+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2154A408000
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r14,rax
       mov       rcx,[r14]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L04
       mov       r8d,[r14+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L04:
       mov       r8,rdx
       lea       rdx,[rdi+8]
       lea       rcx,[r14+8]
       mov       rax,[r14]
       test      dword ptr [rax],1000000
       je        short M01_L06
       cmp       r8,4000
       ja        short M01_L05
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L07
M01_L05:
       call      qword ptr [7FFE5C5B5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L07
M01_L06:
       call      qword ptr [7FFE5C5B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L07:
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+30],80
       mov       dword ptr [rsi+34],8
       mov       dword ptr [rsi+38],100
       mov       dword ptr [rsi+28],1
       mov       [rbp-48],rsi
       mov       rdi,rsi
       mov       [rbp-50],rdi
       mov       r14d,[rdi+30]
       mov       r15d,r14d
       sar       r15d,1F
       and       r15d,7
       add       r14d,r15d
       sar       r14d,3
       mov       edx,r14d
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       [rbp-58],r15
       lea       rdx,[r15+10]
       mov       r8d,r14d
       test      r8d,r8d
       jle       short M01_L10
       mov       [rbp-40],rdx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-88],rax
       lea       rax,[M01_L08]
       mov       [rbp-70],rax
       lea       rax,[rbp-98]
       mov       [rbx+10],rax
       mov       byte ptr [rbx+0C],0
       mov       rax,7FFEEBA43670
       call      rax
M01_L08:
       mov       byte ptr [rbx+0C],1
       cmp       dword ptr [7FFEBC3940DC],0
       je        short M01_L09
       call      qword ptr [7FFEBC3843A8]; CORINFO_HELP_STOP_FOR_GC
M01_L09:
       mov       rcx,[rbp-90]
       mov       [rbx+10],rcx
       test      eax,eax
       jne       near ptr M01_L18
       xor       ecx,ecx
       mov       [rbp-40],rcx
M01_L10:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       r15,[rbp-58]
       mov       rdi,[rbp-50]
       mov       ecx,[rdi+30]
       mov       eax,ecx
       sar       eax,1F
       and       eax,7
       add       ecx,eax
       sar       ecx,3
       cmp       ecx,r14d
       jne       near ptr M01_L17
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       rbx,rax
       mov       rcx,[rbx]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L11
       mov       r8d,[rbx+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L11:
       mov       r8,rdx
       lea       rdx,[r15+8]
       lea       rcx,[rbx+8]
       mov       rax,[rbx]
       test      dword ptr [rax],1000000
       je        short M01_L14
       cmp       r8,4000
       ja        short M01_L13
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M01_L12:
       mov       rdx,rbx
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L19
M01_L13:
       call      qword ptr [7FFE5C5B5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L12
M01_L14:
       call      qword ptr [7FFE5C5B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L12
M01_L15:
       xor       edi,edi
       jmp       near ptr M01_L24
M01_L16:
       mov       rcx,rbx
       call      qword ptr [7FFE5CD72CC8]; System.Security.Cryptography.AesImplementation.GenerateIV()
       jmp       short M01_L20
M01_L17:
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CD642D0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C50CED0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       ecx,eax
       call      qword ptr [7FFE5CC6E340]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rsi,[rbp-48]
       mov       rbx,rsi
       cmp       qword ptr [rbx+10],0
       je        short M01_L16
M01_L20:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       je        short M01_L15
       mov       rcx,rbx
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L21
       mov       r8d,[rdi+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L21:
       mov       r8,rdx
       lea       rdx,[rbx+8]
       lea       rcx,[rdi+8]
       mov       rax,[rdi]
       test      dword ptr [rax],1000000
       je        short M01_L23
       cmp       r8,4000
       ja        short M01_L22
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L24
M01_L22:
       call      qword ptr [7FFE5C5B5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L24
M01_L23:
       call      qword ptr [7FFE5C5B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L24:
       jmp       short M01_L25
M01_L25:
       cmp       qword ptr [rsi+8],0
       jne       short M01_L28
M01_L26:
       mov       rcx,[rsi+10]
       test      rcx,rcx
       je        short M01_L27
       call      qword ptr [7FFE5C4574B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [rsi+10],rcx
M01_L27:
       mov       rcx,rsi
       call      qword ptr [7FFE5C74C2E8]; System.GC.SuppressFinalize(System.Object)
       mov       rax,rdi
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L28:
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE5C4574B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [rsi+8],rcx
       jmp       short M01_L26
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0D0]
       mov       rsi,[rbp-48]
       cmp       qword ptr [rsi+8],0
       je        short M01_L29
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE5C4574B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [rsi+8],rcx
M01_L29:
       cmp       qword ptr [rsi+10],0
       je        short M01_L30
       mov       rcx,[rsi+10]
       call      qword ptr [7FFE5C4574B0]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [rsi+10],rcx
M01_L30:
       mov       rcx,rsi
       call      qword ptr [7FFE5C74C2E8]; System.GC.SuppressFinalize(System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1089
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.GenerateAesKey()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE5C934BA0]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GenerateAesKey()
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.GenerateAesKey()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-0B0],rsp
       lea       rcx,[rbp-98]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       rcx,offset MT_System.Security.Cryptography.AesImplementation
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],1
       mov       dword ptr [rsi+2C],2
       mov       rcx,1CA9F007FF8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r14,rax
       mov       rcx,[r14]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L00
       mov       r8d,[r14+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L00:
       mov       r8,rdx
       lea       rdx,[rdi+8]
       lea       rcx,[r14+8]
       mov       rax,[r14]
       test      dword ptr [rax],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L01:
       call      qword ptr [7FFE5C585BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE5C585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       lea       rcx,[rsi+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1CA9F008000
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       r14,rax
       mov       rcx,[r14]
       mov       edx,[rcx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       test      dword ptr [rcx],80000000
       je        short M01_L04
       mov       r8d,[r14+8]
       movzx     ecx,word ptr [rcx]
       imul      rcx,r8
       add       rdx,rcx
M01_L04:
       mov       r8,rdx
       lea       rdx,[rdi+8]
       lea       rcx,[r14+8]
       mov       rax,[r14]
       test      dword ptr [rax],1000000
       je        short M01_L06
       cmp       r8,4000
       ja        short M01_L05
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L07
M01_L05:
       call      qword ptr [7FFE5C585BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L07
M01_L06:
       call      qword ptr [7FFE5C585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L07:
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+30],80
       mov       dword ptr [rsi+34],8
       mov       dword ptr [rsi+38],100
       mov       dword ptr [rsi+28],1
       mov       [rbp-48],rsi
       mov       rdi,rsi
       mov       [rbp-50],rdi
       mov       r14d,[rdi+38]
       mov       r15d,r14d
       sar       r15d,1F
       and       r15d,7
       add       r14d,r15d
       sar       r14d,3
       mov       edx,r14d
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       [rbp-58],r15
       lea       rdx,[r15+10]
       mov       r8d,r14d
       test      r8d,r8d
       jle       short M01_L10
       mov       [rbp-40],rdx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,offset MD_Interop+BCrypt.BCryptGenRandom(IntPtr, Byte*, Int32, Int32)
       mov       [rbp-88],rax
       lea       rax,[M01_L08]
       mov       [rbp-70],rax
       lea       rax,[rbp-98]
       mov       [rbx+10],rax
       mov       byte ptr [rbx+0C],0
       mov       rax,7FFEEBA43670
       call      rax
M01_L08:
       mov       byte ptr [rbx+0C],1
       cmp       dword ptr [7FFEBC3940DC],0
       je        short M01_L09
       call      qword ptr [7FFEBC3843A8]; CORINFO_HELP_STOP_FOR_GC
M01_L09:
       mov       rcx,[rbp-90]
       mov       [rbx+10],rcx
       test      eax,eax
       jne       near ptr M01_L28
       xor       ecx,ecx
       mov       [rbp-40],rcx
M01_L10:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       r15,[rbp-58]
       mov       ebx,r14d
       shl       rbx,3
       mov       rdi,[rbp-50]
       mov       rcx,[rdi+20]
       cmp       [rcx],cl
       call      qword ptr [7FFE5C424018]; System.Object.MemberwiseClone()
       mov       r8,rax
       test      r8,r8
       je        near ptr M01_L21
       xor       esi,esi
       cmp       dword ptr [r8+8],0
       jle       near ptr M01_L20
M01_L11:
       mov       eax,ebx
       mov       edx,esi
       mov       r14,[r8+rdx*8+10]
       mov       ecx,[r14+10]
       test      ecx,ecx
       je        near ptr M01_L27
       mov       r13d,[r14+8]
       cmp       eax,r13d
       jl        near ptr M01_L23
       cmp       eax,[r14+0C]
       jg        near ptr M01_L23
       sub       eax,r13d
       cdq
       idiv      ecx
       test      edx,edx
       jne       near ptr M01_L23
M01_L12:
       mov       ecx,1
M01_L13:
       test      ecx,ecx
       je        near ptr M01_L21
       mov       rcx,[rdi+20]
       cmp       [rcx],cl
       call      qword ptr [7FFE5C424018]; System.Object.MemberwiseClone()
       mov       r8,rax
       test      r8,r8
       je        near ptr M01_L19
       xor       r12d,r12d
       cmp       dword ptr [r8+8],0
       jle       near ptr M01_L18
M01_L14:
       mov       eax,r12d
       mov       r10,[r8+rax*8+10]
       mov       ecx,[r10+10]
       test      ecx,ecx
       je        near ptr M01_L22
       mov       r9d,[r10+8]
       cmp       ebx,r9d
       jl        near ptr M01_L24
       cmp       ebx,[r10+0C]
       jg        near ptr M01_L24
       mov       eax,ebx
       sub       eax,r9d
       cdq
       idiv      ecx
       test      edx,edx
       jne       near ptr M01_L24
M01_L15:
       mov       ecx,1
M01_L16:
       test      ecx,ecx
       je        short M01_L19
       mov       [rdi+38],ebx
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.AllocateUninitializedClone(System.Object)
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C4D4C00]; System.Runtime.CompilerServices.RuntimeHelpers.GetRawObjectDataSize(System.Object)
       lea       rdx,[r15+8]
       lea       rcx,[rsi+8]
       mov       r8,[rsi]
       test      dword ptr [r8],1000000
       je        near ptr M01_L26
       cmp       rax,4000
       ja        near ptr M01_L25
       mov       r8,rax
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M01_L17:
       mov       rdx,rsi
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L29
M01_L18:
       xor       ecx,ecx
       jmp       short M01_L16
M01_L19:
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CD35650]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4DCED0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L20:
       xor       ecx,ecx
       jmp       near ptr M01_L13
M01_L21:
       mov       rcx,offset MT_System.Security.Cryptography.CryptographicException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFE5CD35650]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFE5C4DCED0]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M01_L22:
       mov       r9d,[r10+8]
       cmp       r9d,ebx
       jne       short M01_L24
       jmp       near ptr M01_L15
M01_L23:
       inc       esi
       cmp       [r8+8],esi
       jle       short M01_L20
       jmp       near ptr M01_L11
M01_L24:
       inc       r12d
       cmp       [r8+8],r12d
       jle       near ptr M01_L18
       jmp       near ptr M01_L14
M01_L25:
       mov       r8,rax
       call      qword ptr [7FFE5C585BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L26:
       mov       r8,rax
       call      qword ptr [7FFE5C585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L27:
       mov       r13d,[r14+8]
       cmp       r13d,eax
       jne       short M01_L23
       jmp       near ptr M01_L12
M01_L28:
       mov       ecx,eax
       call      qword ptr [7FFE5CC3FBE8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L29:
       jmp       short M01_L30
M01_L30:
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE5CD17BC8]; System.Security.Cryptography.SymmetricAlgorithm.get_Key()
       mov       rbx,rax
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE5CD17C38]; System.Security.Cryptography.SymmetricAlgorithm.Dispose()
       mov       rax,rbx
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0D0]
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE5CD17C38]; System.Security.Cryptography.SymmetricAlgorithm.Dispose()
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1191
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.GenerateRandomKey()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE5C954BB8]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GenerateRandomKey()
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.GenerateRandomKey()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE5C5A7360]; System.Guid.NewGuid()
       mov       r8,1D5D9800428
       mov       r8,[r8]
       lea       rcx,[rsp+28]
       mov       rdx,21667913C78
       call      qword ptr [7FFE5C5A7180]; System.Guid.ToString(System.String, System.IFormatProvider)
       nop
       add       rsp,38
       ret
; Total bytes of code 67
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleSHA256Decrypt()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       mov       rdx,2C54607AF90
       call      qword ptr [7FFE5C954BD0]; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Decrypt(System.String, System.String)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Decrypt(System.String, System.String)
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       [rsp+58],rdx
       mov       rbx,rcx
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       test      edx,edx
       je        short M01_L04
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C4F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,[rsp+58]
       test      rcx,rcx
       je        short M01_L02
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M01_L03
       jmp       short M01_L03
M01_L02:
       xor       edx,edx
M01_L03:
       test      edx,edx
       je        near ptr M01_L06
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C4F7318]; System.String.Trim()
       mov       [rsp+58],rax
       lea       rcx,[rsp+28]
       lea       rdx,[rsp+58]
       call      qword ptr [7FFE5C954B40]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String ByRef)
       mov       rcx,rbx
       mov       rdx,[rsp+28]
       mov       r8,[rsp+30]
       call      qword ptr [7FFE5C954B58]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesDecrypt(System.String, Byte[], Byte[])
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L04:
       call      qword ptr [7FFE5CA04570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L05
       call      qword ptr [7FFE5CA042B8]
       mov       rbx,rax
M01_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C546084960
       mov       r8,rbx
       call      qword ptr [7FFE5C716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       call      qword ptr [7FFE5CA04570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L07
       call      qword ptr [7FFE5CA042B8]
       mov       rbx,rax
M01_L07:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C5460799C8
       mov       r8,rbx
       call      qword ptr [7FFE5C716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 318
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleSHA256Encrypt()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,2D72469AF90
       call      qword ptr [7FFE5C934BE8]; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Encrypt(System.String, System.String)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Encrypt(System.String, System.String)
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       [rsp+58],rdx
       mov       rbx,rcx
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       test      edx,edx
       je        short M01_L04
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C4D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,[rsp+58]
       test      rcx,rcx
       je        short M01_L02
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M01_L03
       jmp       short M01_L03
M01_L02:
       xor       edx,edx
M01_L03:
       test      edx,edx
       je        near ptr M01_L06
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C4D7318]; System.String.Trim()
       mov       [rsp+58],rax
       lea       rcx,[rsp+28]
       lea       rdx,[rsp+58]
       call      qword ptr [7FFE5C934B40]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String ByRef)
       mov       rcx,rbx
       mov       rdx,[rsp+28]
       mov       r8,[rsp+30]
       call      qword ptr [7FFE5C934B70]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L04:
       call      qword ptr [7FFE5C9E4570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L05
       call      qword ptr [7FFE5C9E42B8]
       mov       rbx,rax
M01_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2D7246A3D90
       mov       r8,rbx
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       call      qword ptr [7FFE5C9E4570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L07
       call      qword ptr [7FFE5C9E42B8]
       mov       rbx,rax
M01_L07:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2D7246999C8
       mov       r8,rbx
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 318
```

