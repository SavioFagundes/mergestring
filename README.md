# MergeAlternately

Este é um projeto em C# que implementa uma função para mesclar duas strings em ordem alternada. A mesclagem intercala os caracteres de cada string, iniciando por `word1`. Se uma das strings for maior, os caracteres restantes são adicionados ao final.

## 🧠 Descrição do Problema

Dadas duas strings `word1` e `word2`, mescle-as alternando os caracteres de cada uma. Se uma string tiver caracteres restantes após o fim da outra, adicione-os ao final do resultado.

### ✅ Exemplos

- Entrada: `"abc"`, `"pqr"`  
  Saída: `"apbqcr"`

- Entrada: `"ab"`, `"pqrs"`  
  Saída: `"apbqrs"`

- Entrada: `"abcd"`, `"pq"`  
  Saída: `"apbqcd"`

## 💻 Como Executar

### Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) instalado

### Executar via terminal

```bash
dotnet run
Saída esperada
bash
Copiar
Editar
apbqcr
apbqrs
apbqcd
