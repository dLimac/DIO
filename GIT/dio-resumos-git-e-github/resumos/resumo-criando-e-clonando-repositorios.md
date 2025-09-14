# 📌 Criando e clonando repositórios

Nesta aula aprendemos comandos para criar e clonar repositórios utilizando **PowerShell** e **Git**.
>Todos comandos foram executados no **Git Bash**

---

## ⚡ Comandos PowerShell

| Comando | Descrição | Exemplo |
|---------|-----------|---------|
| `mkdir nome-da-pasta` | Cria uma nova pasta no diretório atual | `mkdir dio-resumos-git-e-github` |
| `cd diretorio-da-pasta` | Acessa a pasta especificada | `cd /dio-resumos-git-e-github` |
| `ls` | Lista os arquivos e pastas dentro do diretório atual | `ls` |
| `cat nome-do-arquivo` | Mostra o conteúdo de um arquivo no terminal | `cat README.md` |

---

## 🐙 Comandos Git

| Comando | Descrição | Exemplo |
|---------|-----------|---------|
| `git init` | Inicializa um novo repositório Git na pasta atual | `git init` |
| `git clone URL-do-repositorio` | Clona um repositório remoto para o computador | `git clone https://github.com/usuario/exemplo-repo.git` |
| `git clone URL-do-repositorio nome-da-pasta` | Clona o repositório remoto em uma pasta com o nome definido | `git clone https://github.com/usuario/exemplo-repo.git meu-projeto-clonado` |
| `git clone URL-do-repositorio --branch nome-da-branch --single-branch` | Clona apenas uma branch específica do repositório remoto | `git clone https://github.com/usuario/exemplo-repo.git --branch develop --single-branch` |
| `git remote -v` | Lista os repositórios remotos vinculados ao projeto | `git remote -v` |
| `git remote add nome-do-repositorio URL-do-repositorio` | Vincula a pasta local a um repositório remoto (padrão: `origin`) | `git remote add origin https://github.com/usuario/exemplo-repo.git` |

---
