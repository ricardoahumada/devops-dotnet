# Clone repository and move in
- git clone {repo_url}
- cd {project_name}

# Create a feature branch
- git checkout -b feature/update-readme

# Modify code, add changes and commit
- git add .
- git commit -m "{meaningful text}"

# Set branch oringin
- git push --set-upstream origin feature/update-readme
- git push

# Go to Bitbucket/Gitlab/Github and generate a PR
- New pull request
- Add reviewers
- Send review request -> reviewer receive mail

# Validate PR by reviwer
- Go to review request
- Add comments
- Aprove
- Merge pull request --> confirm/validate
- Merge and Delete branche
