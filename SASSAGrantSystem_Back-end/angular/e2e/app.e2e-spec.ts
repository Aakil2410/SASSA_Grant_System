import { SASSAGrantSystemTemplatePage } from './app.po';

describe('SASSAGrantSystem App', function() {
  let page: SASSAGrantSystemTemplatePage;

  beforeEach(() => {
    page = new SASSAGrantSystemTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
