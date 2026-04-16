# DLL-CSharp-Estatistica-Calculo-Quartil

Exemplo de criação de um componente DLL em CSharp para ser utilizado em Csharp ou em outras linguaguens como componente COM/ActiveX para fazer Estatisticas e Cálculo do Quadro de Quartil

## O que você vai encontrar neste projeto

- **DLL** - Criação de DLL em Csharp
- **FoxPro** - Utilização do uso como componente DLL e consumindo dados retornados em formato Json.
- **Json** - Serialização e desserialização utilizado nas linguaguens   
- **COM** - Criação de Componente Objetos COM/ActiveX em .NET onde para ser usadas por outras linguaguens (rundll32), devem ter e serem criadas como ComVisible(true) e serem registradas para interoperação com registro (regasm.exe). 

## Execução da aplicação em outras linguaguens

A DLL deve ser registrada com o seguinte .BAT, necessário ajustar diretório do sistema no arquivo BAT, para ser utilizado como Componente COM/ActiveX por outras linguaguens (Delphi, Visual Basic, FoxPro)

```bash
	@ECHO OFF
	echo %cd%
	C:\Windows\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe D:\DLLTeste3\DLLTeste3\Foxpro\DLLTeste3.dll /codebase /tlb
	C:\Windows\Microsoft.NET\Framework64\v4.0.30319\RegAsm.exe D:\DLLTeste3\DLLTeste3\Foxpro\DLLTeste3.dll /codebase /tlb
	timeout /t 20
	EXIT
```

# Calculo Quartil

Os quartis são medidas estatísticas que dividem um conjunto de dados ordenados (do menor para o maior) em quatro partes iguais, cada uma contendo 25% dos dados. Eles são fundamentais para entender a distribuição e a dispersão dos dados, indo além do que uma simples média pode mostrar.
