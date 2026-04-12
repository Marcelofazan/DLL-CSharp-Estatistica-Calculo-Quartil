# DLL Quartil

Exemplo de criação de um componente DLL em Csharp para ser utilizado em Csharp, ou outras linguaguens como componente COM/ActiveX de quadro de quartil e calculos de Estatisticas

## Requisitos

- Registro da DLL se for utilizado como Componente COM/ActiveX por outras linguaguens

# O que você vai encontrar neste projeto

- **FoxPro** - Utilização do uso como componente, chamando a DLL e retornando Dados Json.
- **DLL** - Criação de DLL em Csharp
- **Json** - Uso Calculo em Csharp e Serealização para ser lido e descerealizado por outras linguaguens   
- **COM** - Uso de Componentes Objetos COM/ActiveX , DLLs. DLLs .NET que precisam ser chamadas pelo rundll32 que devem ter classes ComVisible(true) e ser registradas com regasm.exe para interoperação


## Execução correto em linguaguens

Para executar a DLL ser executada como componente visivel em linguaguens diversas como Visual Basic, Delphi , FoxPro necessário corrigir o caminho do sistema no arquivo BAT:

Registrar arquivo .BAT 

```bash
	@ECHO OFF
	echo %cd%
	C:\Windows\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe D:\DLLTeste3\DLLTeste3\Foxpro\DLLTeste3.dll /codebase /tlb
	C:\Windows\Microsoft.NET\Framework64\v4.0.30319\RegAsm.exe D:\DLLTeste3\DLLTeste3\Foxpro\DLLTeste3.dll /codebase /tlb
	timeout /t 20
	EXIT
```

## Calculo Quartil

Os quartis são medidas estatísticas que dividem um conjunto de dados ordenados (do menor para o maior) em quatro partes iguais, cada uma contendo 25% dos dados. Eles são fundamentais para entender a distribuição e a dispersão dos dados, indo além do que uma simples média pode mostrar.
