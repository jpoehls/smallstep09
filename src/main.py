import web
import os
from Cheetah.Template import Template

urls = (
        "/", "pages",
        "/(.*)", "pages"
)

template_folder = "pages/"

app = web.application(urls, globals()) 

class pages:      
    def GET(self, path="index"):          
        tmpl_file = template_folder + path + ".htm"
        if os.path.exists(tmpl_file):
            template_values = { "xyz":"You",}
            tmpl = Template( file = tmpl_file, searchList = (template_values,) )
            return tmpl
        else:
            return "404: Page not found"

main = app.cgirun()