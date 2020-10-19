# Integrate bitbucket - jenkins
## Config jenkins
- install plugin: bitbucket
- restart jenkins
- update jenkins task to trigger: (tip) Build when a change is pushed to BitBucket
- ensure jenkins has access to internet or disable public firewall
## Config bitbucket
- add webhook to bitbucket repo: http://&lt;ip>:8080/bitbucket-hook/
- config push/merge
