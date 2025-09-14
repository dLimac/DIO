# 📌 Salvando alterações no repositório local

Nesta aula aprendemos comandos para salvar alterações em um repositório local utilizando **Git** e **PowerShell**.

---

## ⚡ Comandos PowerShell

| Comando | Descrição | Exemplo |
|---------|-----------|---------|
| `touch nome-do-arquivo` | Cria um arquivo em branco Obs.: Criamos vários arquivos se separarmos os nome com espaço | `touch README.md` Criando mais de um arquivo `touch README1.md README2.md`|
| `touch resumos/resumo-salvando-alteracoes-no-repositorio-local.md` | Cria um arquivo dentro de uma pasta (se a pasta não existir, precisa ser criada antes) | `touch resumos/resumo-salvando-alteracoes-no-repositorio-local.md` |
| `clear` | Limpa o console/terminal | `clear` |
| `echo "ignore/" > .gitignore` | Adiciona a pasta **ignore/** no `.gitignore` | `echo "node_modules/" > .gitignore` |
| `echo > .gitignore` | Limpa o conteúdo do arquivo `.gitignore` (remove todas as regras) | `echo > .gitignore` |

---

## 🐙 Comandos Git

| Comando | Descrição | Exemplo |
|---------|-----------|---------|
| `git status` | Mostra o estado atual do repositório (arquivos modificados, não rastreados, prontos para commit) | `git status` |
| `git add .` | Adiciona **todos os arquivos** modificados para a área de preparação (staging) | `git add .` |
| `git commit -m "mensagem-do-commit"` | Salva as alterações no repositório local com uma mensagem | `git commit -m "Adiciona resumo da aula de commits"` |
| `git log` | Mostra o histórico de commits realizados no repositório | `git log` |
| `.gitkeep` | Arquivo usado para versionar pastas vazias (criar manualmente dentro da pasta) | `touch gitkeep-test/.gitkeep` - PowerShell Command - |

---

## ⌨️ Atalhos úteis

| Atalho | Descrição |
|--------|-----------|
| `CTRL + L` | Limpa o terminal (atalho equivalente ao comando `clear`) |
|`WIN + "."` | Abre os emojis |
---
