import web
import os
from google.appengine.api import users
from Cheetah.Template import Template

urls = (
        "/(.*)", "pages"
)

template_folder = "pages/"

app = web.application(urls, globals()) 

class pages:      
    def GET(self, path=None):
        
        user = users.get_current_user()
        
        if user:
            path = "me"
        else:
            path = "index"    
                  
        tmpl_file = template_folder + path + ".htm"
        if os.path.exists(tmpl_file):
            template_values = { "xyz":"You",}
            tmpl = Template( file = tmpl_file, searchList = (template_values,) )
            return tmpl
        else:
            return "404: Page not found"

main = app.cgirun()