import { MyAbpLearnTemplatePage } from './app.po';

describe('MyAbpLearn App', function() {
  let page: MyAbpLearnTemplatePage;

  beforeEach(() => {
    page = new MyAbpLearnTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
