import web
from Cheetah.Template import Template

urls = (
        "/index", "index",
        "/(.*)", "site"
)

template_folder = "pages/"

app = web.application(urls, globals()) 

class site:
    def GET(self, path):
        return "Hey buddy! You requested: " + path
        
class index:
    def GET(self):
        tmpl_file = template_folder + "index.htm"
        template_values = { "xyz":"You",}
        tmpl = Template( file = tmpl_file, searchList = (template_values,) )
        return tmpl

main = app.cgirun()