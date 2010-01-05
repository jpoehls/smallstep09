from google.appengine.ext import webapp
from google.appengine.ext.webapp.util import run_wsgi_app
from google.appengine.ext import db

class Profile(db.Model):
    username = db.StringProperty(required=True)
    weekday_days = db.ListProperty(int)
    weekend_days = db.StringProperty(int)
    twitter_username = db.StringProperty()
    email_address = db.StringProperty()
    mobile_phone = db.PhoneNumberProperty()

class Goal(db.Model):
    user = db.ReferenceProperty(Profile, required=True)
    name = db.StringProperty(required=True)
    target_count = db.IntegerProperty()
    target_interval = db.IntegerProperty()
    end_date = db.DateProperty()

class Progress(db.Model):
    goal = db.ReferenceProperty(Goal)
    count = db.IntegerProperty()
    date = db.DateTimeProperty(auto_now_add=True)

class GoalSvc(webapp.RequestHandler):
    def get(self):
        self.response.headers['Content-Type'] = 'text/plain'
        self.response.out.write('Hello, you got a goal!')
        
class ProgressSvc(webapp.RequestHandler):
    def get(self):
        self.response.headers['Content-Type'] = 'text/plain'
        self.response.out.write('Hello, you got a progress!')
        
class ProfileSvc(webapp.RequestHandler):   
    def get(self, username):
        self.response.headers['Content-Type'] = 'text/plain'
        self.response.out.write('Hello ' + username + ', you got a profile!')

class UserSvc(webapp.RequestHandler):
    def get(self):
        self.response.headers['Content-Type'] = 'text/plain'
        self.response.out.write('Hello, you got a user!')

application = webapp.WSGIApplication(
                          [('/svc/goals', GoalSvc),
                           ('/svc/goals/.*', GoalSvc),
                           ('/svc/progress', ProgressSvc),
                           ('/svc/progress/.*', ProgressSvc),
                           ('/svc/profiles/(.*)', ProfileSvc),
                           ('/svc/users', UserSvc),
                           ('/svc/users/.*', UserSvc)],
                          debug=True)

def main():
    run_wsgi_app(application)   
    
if __name__ == "__main__":
    main()
