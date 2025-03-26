Repositório Dedicado para Aprendizagem em Desenvolvimento C# .NET, Git e GitHub

# 📘 Documentação de Comandos do Git

---

## 🛠️ Comandos Básicos
- **`git init`**: Inicializa um novo repositório Git no diretório atual.
- **`git clone <url>`**: Clona um repositório remoto para o diretório local.
- **`git status`**: Exibe o status atual do repositório, incluindo arquivos modificados e não rastreados.
- **`git add <arquivo>`**: Adiciona um arquivo específico à área de stage (preparação para commit).
- **`git add .`**: Adiciona todos os arquivos modificados à área de stage.
- **`git commit -m "<mensagem>"`**: Cria um commit com as alterações na área de stage e uma mensagem descritiva.
- **`git log`**: Exibe o histórico de commits do repositório.

---

## 🌿 Trabalhando com Branches
- **`git branch`**: Lista todas as branches no repositório.
- **`git branch <nome>`**: Cria uma nova branch com o nome especificado.
- **`git checkout <branch>`**: Alterna para a branch especificada.
- **`git checkout -b <branch>`**: Cria e alterna para uma nova branch.
- **`git merge <branch>`**: Mescla a branch especificada na branch atual.

---

## 🌐 Repositórios Remotos
- **`git remote add origin <url>`**: Adiciona um repositório remoto com o nome "origin".
- **`git push -u origin <branch>`**: Envia as alterações da branch especificada para o repositório remoto.
- **`git pull`**: Puxa as alterações do repositório remoto para o local.

---

## 🔧 Outros Comandos Úteis
- **`git diff`**: Mostra as diferenças entre os arquivos modificados e o último commit.
- **`git reset <arquivo>`**: Remove um arquivo da área de stage.
- **`git stash`**: Salva temporariamente as alterações não commitadas para limpar o diretório de trabalho.
- **`git stash pop`**: Restaura as alterações salvas com `git stash`.
- **`git tag <nome>`**: Cria uma tag no commit atual.

---

## 🚀 Comandos Avançados
- **`git rebase <branch>`**: Reaplica os commits da branch atual sobre a branch especificada.
- **`git cherry-pick <commit>`**: Aplica um commit específico de outra branch na branch atual.
- **`git revert <commit>`**: Reverte um commit específico, criando um novo commit que desfaz as alterações.
- **`git reset --hard <commit>`**: Restaura o repositório para o estado de um commit específico, descartando alterações posteriores.
- **`git log --oneline --graph --all`**: Exibe o histórico de commits em um formato gráfico e resumido.
- **`git stash apply`**: Aplica as alterações salvas com `git stash` sem removê-las da pilha de stashes.
- **`git fetch --prune`**: Atualiza as referências remotas e remove branches remotas que não existem mais.
- **`git clean -f`**: Remove arquivos não rastreados do diretório de trabalho.
- **`git bisect`**: Usa uma busca binária para encontrar o commit que introduziu um bug.
- **`git blame <arquivo>`**: Mostra quais commits e autores modificaram cada linha de um arquivo.
- **`git reflog`**: Exibe o histórico de referências para o repositório local, incluindo commits que não estão mais acessíveis.
- **`git submodule add <url>`**: Adiciona um submódulo ao repositório.
- **`git archive --format=zip --output=<arquivo>.zip <branch>`**: Cria um arquivo zip do conteúdo de uma branch específica.
- **`git config --global alias.<alias> "<comando>"`**: Cria um atalho para um comando Git.