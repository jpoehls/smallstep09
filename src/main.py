import web
import os
from google.appengine.api import users
from Cheetah.Template import Template

urls = (
        "/(.*)", "default"
)

template_folder = "pages/"

app = web.application(urls, globals()) 

class login:
    def GET(self):
        web.redirect(users.createLoginUrl())
        return None

class default:
    def GET(self, path=None):
        
        user = users.get_current_user()
        
        vars = {}

        if user:
            path = "me"
            vars['logoutUrl'] = users.create_logout_url("/")
            vars['nickname'] = user.nickname();
        else:
            path = "index"    
            vars['loginUrl'] = users.create_login_url("/")
                  
        tmpl_file = template_folder + path + ".htm"
        if os.path.exists(tmpl_file):
            tmpl = Template( file = tmpl_file, searchList = (vars,) )
            return tmpl
        else:
            return "404: Page not found"

main = app.cgirun()